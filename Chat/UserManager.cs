using SKYNET;
using SKYNET.Common;
using SKYNET.Controls;
using System;
using System.Drawing;
using System.IO;
using System.Net;
using System.Web.Script.Serialization;
using System.Windows.Forms;

public class UserManager
{
    public static UserBox GetUserBoxFromID(string ID)
    {
        for (int i = 0; i < frmMain.frm.UserContainer.Controls.Count; i++)
        {
            if (frmMain.frm.UserContainer.Controls[i] is UserBox)
            {
                UserBox Box = (UserBox)frmMain.frm.UserContainer.Controls[i];
                if (Box.ID == ID)
                {
                    return Box;
                }
            }
        }
        if (frmMain.frm.LobbyGroup.ID == ID)
        {
            return frmMain.frm.LobbyGroup;
        }
        if (LoadUserFile(ID, out UserBox uBox))
        {
            return uBox;
        }
        //modCommon.Show("null");

        return null;
    }
    private static UserBox GetUserBoxFromIDInChatControl(string ID)
    {
        for (int i = 0; i < frmMain.frm.UserContainer.Controls.Count; i++)
        {
            if (frmMain.frm.UserContainer.Controls[i] is UserBox)
            {
                UserBox Box = (UserBox)frmMain.frm.UserContainer.Controls[i];
                if (Box.ID == ID)
                {
                    return Box;
                }
            }
        }
        if (frmMain.frm.LobbyGroup.ID == ID)
        {
            return frmMain.frm.LobbyGroup;
        }

        return null;
    }
    public static void DeselectAll()
    {
        for (int i = 0; i < frmMain.frm.UserContainer.Controls.Count; i++)
        {
            if (frmMain.frm.UserContainer.Controls[i] is UserBox)
            {
                UserBox Box = (UserBox)frmMain.frm.UserContainer.Controls[i];
                Box.Selected = false;
            }
            frmMain.frm.LobbyGroup.Selected = false;

        } 
    }

    public static bool ExistUser(string ID)
    {
        UserBox Box = GetUserBoxFromID(ID);

        if (Box != null)
            return true;

        return false;
    }
    public static bool ExistUserInChatControl(string ID)
    {
        UserBox Box = GetUserBoxFromIDInChatControl(ID);

        if (Box != null)
            return true;

        return false;
    }

    public static string GetUserAvatarFromID(string ID, bool web, string Username = "")
    {
        string AvatarTemp = Path.Combine(modCommon.TEMP_PATH, "Avatars");
        string AvatarData = Path.Combine(modCommon.GetPath(), "Data", "Avatars");
        string AvatarLetter = Path.Combine(modCommon.TEMP_PATH, "Letters");
        string filename = ID + ".png";

        if (!Directory.Exists(AvatarTemp) && !Directory.Exists(AvatarData))
        {
            frmMain.CreateDirectories();
        }

        if (web)
        {
            if (File.Exists(Path.Combine(AvatarTemp, filename)))
            {
                return Path.Combine(AvatarTemp, filename);
            }
            if (File.Exists(Path.Combine(AvatarData, filename)))
            {
                File.Copy(Path.Combine(AvatarData, filename), Path.Combine(AvatarTemp, filename));
                return Path.Combine(AvatarTemp, filename);
            }
        }

        if (File.Exists(Path.Combine(AvatarData, filename)))
        {
            return Path.Combine(AvatarData, filename);
        }

        if (File.Exists(Path.Combine(AvatarLetter, filename)))
        {
            return Path.Combine(AvatarLetter, filename);
        }


        string UserName = Username;
        if (string.IsNullOrEmpty(UserName))
            UserName = GetUserNameFromID(ID);

        Bitmap letter = (Bitmap)ImageManager.CropToCircle(ImageManager.CreateLetterImage(UserName));
        string letterName = Path.Combine(AvatarLetter, filename);
        letter.Save(letterName);
        return letterName;

    }

    internal static string GetUserNameFromID(string ID)
    {
        UserBox Box = GetUserBoxFromID(ID);

        if (Box != null)
            return Box.UserName;

        if (ID == ChatSettings.UserID)
            return ChatSettings.UserName;

        return "Anonymous";
    }



    public static void AddOrUpdateUser(User user)
    {
        bool Exist = false;

        UserBox Box = GetUserBoxFromID(user.ID);

        if (Box == null)
        {
            AddUser(user);
        }
        else
        {
            Box = new UserBox();
            Box.UserName = user.UserName;
            Box.AvatarLength = user.AvatarLength;
            Box.Status = user.Status;
            Box.ID = user.ID;
            Box.Name = user.ID;
            Box.IP = user.IP;
            Box.ConnectedTime = user.ConnectedTime;
            Box.MachineName = user.MachineName;

            UserToSave UserToSave = GetUserFromUserBox(Box);
            SaveUserFile(UserToSave);
        }
    }
    public static void AddUser(User user)
    {
        if (user.ID.Contains("0000") || string.IsNullOrEmpty(user.ID))
        {
            return;
        }
        UserBox NewUser = new UserBox();
        NewUser.UserName = user.UserName;
        NewUser.MachineName = user.MachineName;
        NewUser.IsGroup = user.IsGroup;
        NewUser.Status = user.Status;
        NewUser.IP = user.IP;
        NewUser.ID = user.ID;
        NewUser.Name = user.ID;
        NewUser.Dock = DockStyle.Top;
        NewUser.BringToFront();

        if (user.Avatar == null)
            NewUser.Avatar = (Bitmap)ImageManager.ImageFromFile(user.ImagePath);
        else
            NewUser.Avatar = user.Avatar;

        NewUser.Selected = false;
        NewUser.MouseClick += frmMain.frm.User_MouseClick;

        ChatControl chatControl = new ChatControl(user.ID);
        chatControl.ChatID = user.ID;
        chatControl.Dock = DockStyle.Fill;
        chatControl.Visible = false;

        NewUser.ChatControl = chatControl;

        if (!ExistUserInChatControl(user.ID))
        {
            frmMain.frm.UserContainer.Controls.Add(NewUser);
            frmMain.frm.ChatContainer.Controls.Add(chatControl);
        }
        UserToSave UserToSave = GetUserFromUserBox(NewUser);

        SaveUserFile(UserToSave);

    }

    private static bool LoadUserFile(string ID, out UserBox newUser)
    {
        string filename = Path.Combine(modCommon.USERS_PATH, ID + ".user");

        if (File.Exists(filename))
        {
            string json = File.ReadAllText(filename);
            UserToSave UserToLoad = new JavaScriptSerializer().Deserialize<UserToSave>(json);
            newUser = GetUserBoxFromUser(UserToLoad);
            return true;
        }
        newUser = null;
        return false;
    }
    private static void SaveUserFile(UserToSave UserToSave)
    {
        string json = new JavaScriptSerializer().Serialize(UserToSave);
        string filename = Path.Combine(modCommon.USERS_PATH, UserToSave.ID + ".user");
        File.WriteAllText(filename, json);

    }
    public static void RemoveUserBox(string ID)
    {
        UserBox Box = GetUserBoxFromID(ID);

        if (Box != null)
            frmMain.frm.UserContainer.Controls.Remove(Box);
    }
    internal static void RemoveUserBox(UserBox userBox)
    {
        if (frmMain.frm.UserContainer.Controls.Contains(userBox))
        {
            frmMain.frm.UserContainer.Controls.Remove(userBox);
        }
    }

    public static void SetUserStatus(string ID, UserStatus type)
    {
        UserBox Box = GetUserBoxFromID(ID);

        if (Box != null) 
            Box.Status = type;
    }



    public static void ClearUsers()
    {
        frmMain.frm.UserContainer.Controls.Clear();
    }

    internal static void SetActivateBox(string ID, bool Activated)
    {
        UserBox Box = GetUserBoxFromID(ID);

        if (Box != null)
            Box.Activated = Activated;
    }
    private static UserToSave GetUserFromUserBox(UserBox newUser)
    {
        UserToSave UserToSave = new UserToSave();
        UserToSave.AvatarLength = newUser.AvatarLength;
        UserToSave.ConnectedTime = newUser.ConnectedTime;
        UserToSave.ID = newUser.ID;
        UserToSave.IP = newUser.IP.ToString();
        UserToSave.IsGroup = newUser.IsGroup;
        UserToSave.MachineName = newUser.MachineName;
        UserToSave.UserName = newUser.UserName;

        return UserToSave;
    }
    private static UserBox GetUserBoxFromUser(UserToSave newUser)
    {
        UserBox UserToLoad = new UserBox();
        //UserToLoad.Avatar = newUser.Avatar;
        UserToLoad.AvatarLength = newUser.AvatarLength;
        UserToLoad.ConnectedTime = newUser.ConnectedTime;
        UserToLoad.ID = newUser.ID;

        try { UserToLoad.IP = IPAddress.Parse(newUser.IP); } catch { }

        UserToLoad.IsGroup = newUser.IsGroup;
        UserToLoad.MachineName = newUser.MachineName;
        //UserToLoad.Status = newUser.;
        UserToLoad.UserName = newUser.UserName;

        return UserToLoad;
    }
}
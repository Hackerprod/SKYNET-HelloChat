using System;
using System.Drawing;
using System.Net;

public class User
{
    public string UserName { get; set; }
    public UserStatus Status { get; set; }
    public string ID { get; set; }
    public string ImagePath { get; set; }
    public string MachineName { get; set; }
    public IPAddress IP { get; set; }
    public string State { get; set; }
    public int AvatarLength { get; set; }
    public DateTime ConnectedTime { get; set; }
    public Bitmap Avatar { get; set; }
    public bool IsGroup { get; set; }
}
public class UserToSave
{
    public string UserName { get; set; }
    public string ID { get; set; }
    public string ImagePath { get; set; }
    public string MachineName { get; set; }
    public string IP { get; set; }
    public int AvatarLength { get; set; }
    public DateTime ConnectedTime { get; set; }
    public bool IsGroup { get; set; }
}
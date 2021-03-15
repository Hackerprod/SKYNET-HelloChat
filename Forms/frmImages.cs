using SKYNET.Common;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Transparencia;

public partial class frmImages : Form
{
    private bool mouseDown;     //Mover ventana
    private Point lastLocation; //Mover ventana

    public static frmImages frm;
    public frmImages()
    {
        InitializeComponent();
        CheckForIllegalCrossThreadCalls = false;  //Para permitir acceso a los subprocesos
        frm = this;
    }
    private void Event_MouseMove(object sender, MouseEventArgs e)
    {
        if (mouseDown)
        {
            Location = new Point((Location.X - lastLocation.X) + e.X, (Location.Y - lastLocation.Y) + e.Y);
            Update();
            Opacity = 0.93;
        }
    }

    private void Event_MouseDown(object sender, MouseEventArgs e)
    {
        mouseDown = true;
        lastLocation = e.Location;

    }

    private void Event_MouseUp(object sender, MouseEventArgs e)
    {
        mouseDown = false;
        Opacity = 100;
    }


    private void cancelBtn_Click(object sender, EventArgs e)
    {
        Cancel.PerformClick();
        Close();
    }

    private void acepctBtn_Click(object sender, EventArgs e)
    {
        ok.PerformClick();
    }



    private void FrmMessage_Activated(object sender, EventArgs e)
    {
        Visible = true;
    }

    private void FrmMessage_Deactivate(object sender, EventArgs e)
    {
        Visible = false;
    }
    private void Control_MouseMove(object sender, MouseEventArgs e)
    {
        try
        {
            Control control = (Control)sender;
            if (control is PictureBox)
            {
                switch (control.Name)
                {
                    case "ClosePic": CloseBox.BackColor = Color.FromArgb(60, 155, 244); break;
                        //case "MinPic": MinBox.BackColor = Color.FromArgb(60, 155, 244); break;
                }
            }
            if (control is Panel)
            {
                switch (control.Name)
                {
                    case "CloseBox": CloseBox.BackColor = Color.FromArgb(60, 155, 244); break;
                        //case "MinBox": MinBox.BackColor = Color.FromArgb(60, 155, 244); break;
                }
            }
        }
        catch { }
    }

    private void Control_MouseLeave(object sender, EventArgs e)
    {
        //MinBox.BackColor = BackColor;
        CloseBox.BackColor = BackColor;
    }

    private void CloseBox_Click(object sender, EventArgs e)
    {
        Close();
    }

    private void FrmClaro_Click(object sender, EventArgs e)
    {
    }

    private void Btn_Transparency_Click(object sender, EventArgs e)
    {
        new frmTop().ShowDialog();
    }

    private void Searchbtn_Click(object sender, EventArgs e)
    {
        frmPhoto FrmPhoto = new frmPhoto();
        OpenFileDialog ofdPhoto = new OpenFileDialog
        {
            FileName = string.Empty,
            Filter = "Picture files|*.jpg;*.bmp;*.gif|All Files|*.*",
            Title = "Select Photo",
            RestoreDirectory = true
        };
        DialogResult num = ofdPhoto.ShowDialog();
        //pctPhoto.Tag = string.Empty;
        this.Visible = false;
        WindowState = FormWindowState.Minimized;
        if (num == DialogResult.OK)
        {
            //pctPhoto.Tag = "1";
            int width = 413;
            int height = 423;
            Image image = ImageManager.ImageFromFile(ofdPhoto.FileName);
            Image image2 = FrmPhoto.ResizeImage(ofdPhoto.FileName, image, new Size(width, height));
            FrmPhoto.picSelectPhoto.Width = width;
            FrmPhoto.picSelectPhoto.Height = height;
            FrmPhoto.picSelectPhoto.Image = image2;
            FrmPhoto.picSelectPhoto.Location = new Point((int)Math.Round(unchecked((double)checked(frmPhoto.frm.pnlPhoto.Width - frmPhoto.frm.picSelectPhoto.Width) / 2.0)), (int)Math.Round(unchecked((double)checked(frmPhoto.frm.pnlPhoto.Height - frmPhoto.frm.picSelectPhoto.Height) / 2.0)));
            FrmPhoto.ShowDialog();
            FrmPhoto.BringToFront();
            LoadImage();
        }
        this.Visible = true;
        WindowState = FormWindowState.Normal;

    }
    Image avatar;
    private void LoadImage()
    {
        if (File.Exists("avatar.png"))
        {
            avatar = ImageManager.ImageFromFile("avatar.png");
            if (!Redondeado.Checked)
                Avatar.Image = avatar;
            else
                Avatar.Image = ImageManager.CropToCircle(avatar);
        }
    }

    private void Screen_Click(object sender, EventArgs e)
    {
        ScreenCapture screenCapture = new ScreenCapture();
        screenshot.Image = screenCapture.CaptureScreen();
    }

    private void Redondeado_CheckedChanged(object sender, EventArgs e)
    {
        if (Redondeado.Checked)
        {
            Avatar.Image = ImageManager.CropToCircle(avatar);
        }
        else
            Avatar.Image = avatar;
    }

    private void CreateImage_Click(object sender, EventArgs e)
    {
        Bitmap letter = ImageManager.CreateLetterImage(word.Text);
        LetterIMG.Image = ImageManager.CropToCircle(letter);
    }

    private void FrmImages_Load(object sender, EventArgs e)
    {
        if (File.Exists("avatar.png"))
        {
            avatar = ImageManager.ImageFromFile("avatar.png");
            if (!Redondeado.Checked)
                Avatar.Image = avatar;
            else
                Avatar.Image = ImageManager.CropToCircle(avatar);
        }

    }
}


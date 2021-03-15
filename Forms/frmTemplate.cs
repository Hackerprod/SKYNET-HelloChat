using System;
using System.Drawing;
using System.Windows.Forms;
using Transparencia;

public partial class frmTemplate : Form
{
    private bool mouseDown;     //Mover ventana
    private Point lastLocation; //Mover ventana

    public static frmTemplate frm;
    public frmTemplate()
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

    }



    private void frmMessage_Activated(object sender, EventArgs e)
    {

    }

    private void frmMessage_Deactivate(object sender, EventArgs e)
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

}


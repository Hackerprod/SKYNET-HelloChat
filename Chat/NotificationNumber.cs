using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.ComponentModel;
using System.Drawing.Text;
using System.Runtime.InteropServices;
class NotificationNumber : Control
{

    private int _Value = 0;
    private int _Maximum = 1000;
    Color _Color = default;

    public int Value
    {
        get
        {
            if (this._Value == 0)
            {
                return 0;
            }
            return this._Value;
        }
        set
        {
            if (value > this._Maximum)
            {
                value = this._Maximum;
            }
            this._Value = value;
            this.Invalidate();
        }
    }

    public int Maximum
    {
        get
        {
            return this._Maximum;
        }
        set
        {
            if (value < this._Value)
            {
                this._Value = value;
            }
            this._Maximum = value;
            this.Invalidate();
        }
    }

    public Color Color
    {
        get
        {
            return this._Color;
        }
        set
        {
            this._Color = value;
            this.Invalidate();
        }
    }



    public NotificationNumber()
    {
        SetStyle(ControlStyles.SupportsTransparentBackColor, true);
        SetStyle(ControlStyles.UserPaint, true);

        Text = null;
        DoubleBuffered = true;
    }

    protected override void OnResize(EventArgs e)
    {
        base.OnResize(e);
        Height = 20;
        //Width = 20;
    }

    protected override void OnPaint(PaintEventArgs e)
    {
        base.OnPaint(e);
        var _G = e.Graphics;

        string myString = _Value > 99 ? "+99" : _Value.ToString();

        _G.Clear(BackColor);
        _G.SmoothingMode = SmoothingMode.AntiAlias;
        SolidBrush EllipseColor = new SolidBrush(Color);

        int width = 18;
        switch (myString.Length)
        {
            case 1:
                width = 18;
                break;
            case 2:
                width = 22;
                break;
            case 3:
                width = 26;
                break;
            default:
                width = 18;
                break;
        }

        // Fills the body with LGB Color
        _G.FillEllipse(EllipseColor, new Rectangle(new Point(0, 0), new Size(width, 18)));
        
        Width = width + 2;

        _G.DrawString(myString, new Font("Segoe UI", 8, FontStyle.Bold), new SolidBrush(Color.White), new Rectangle(0, 0, width, Height), new StringFormat
        {
            Alignment = StringAlignment.Center,
            LineAlignment = StringAlignment.Center
        });
        e.Dispose();
    }

}


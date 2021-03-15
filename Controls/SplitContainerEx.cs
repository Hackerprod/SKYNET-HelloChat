using System.Drawing;
using System.Reflection;
using System.Windows.Forms;

namespace SkynetChat
{
  public class SplitContainerEx : SplitContainer
  {
        public Color SplitterColor { get; set; }
        public SplitContainerEx()
        {
            DoubleBuffered = true;
            SetStyle(ControlStyles.UserPaint | ControlStyles.ResizeRedraw | ControlStyles.SupportsTransparentBackColor | ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer, value: true);
            MethodInfo method = typeof(Control).GetMethod("SetStyle", BindingFlags.Instance | BindingFlags.NonPublic);
            object[] parameters = new object[2]
            {
            ControlStyles.UserPaint | ControlStyles.ResizeRedraw | ControlStyles.SupportsTransparentBackColor | ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer,
            true
            };
            method.Invoke(base.Panel1, parameters);
            method.Invoke(base.Panel2, parameters);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            if (SplitterColor == null)
            {
                SplitterColor = ColorTranslator.FromHtml("#E1E1E1");
            }
            Rectangle rectangle = default(Rectangle);
            base.SplitterWidth = 3;
            rectangle = new Rectangle(base.SplitterDistance + 2, 0, checked(base.SplitterWidth - 2), base.Height);
            using (SolidBrush brush = new SolidBrush(SplitterColor))
            {
                e.Graphics.FillRectangle(brush, rectangle);
            }
        }
    }
}

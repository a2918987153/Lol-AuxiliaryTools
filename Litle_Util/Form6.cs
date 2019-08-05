using System;
using System.Drawing;
using System.Windows.Forms;

namespace Litle_Util
{
    public partial class Form6 : Form
    {
        Form form;
        public Form6(Form form)
        {
            this.form = form;
            InitializeComponent();
        }

        public void Add_Rec_Pic_Box(Hero hero)
        {
            for (int i = this.Controls.Count - 1; i >= 0; i--)
            {
                if (this.Controls[i].GetType().ToString().Equals("System.Windows.Forms.PictureBox"))
                {
                    this.Controls.Remove(this.Controls[i]);
                }
            }
            int index = 0;
            foreach (Bitmap bitmap in hero.RecEqus)
            {
                if(bitmap != null)
                {
                    PictureBox pic = new PictureBox();
                    pic.BackgroundImage = bitmap;
                    pic.Location = new Point(index * Litle_Util.Properties.Settings.Default.IconSize, 0);
                    pic.Size = new Size(Litle_Util.Properties.Settings.Default.IconSize, Litle_Util.Properties.Settings.Default.IconSize);
                    pic.BackgroundImageLayout = ImageLayout.Zoom;
                    pic.MouseEnter += new EventHandler(Mouse_Enter);
                    pic.MouseLeave += new EventHandler(Mouse_Leave);
                    this.Controls.Add(pic);
                }
                index++;
            }

        }

        private void Form6_Load(object sender, EventArgs e)
        {
            this.Location = new Point(this.form.Location.X + this.form.Size.Width, 
                this.form.Location.Y);
            this.Opacity = Litle_Util.Properties.Settings.Default.Opacity;
        }

        private void Mouse_Enter(object sender, EventArgs e)
        {
            this.Opacity = 1;
        }

        private void Mouse_Leave(object sender, EventArgs e)
        {
            this.Opacity = Litle_Util.Properties.Settings.Default.Opacity;
        }
    }
}

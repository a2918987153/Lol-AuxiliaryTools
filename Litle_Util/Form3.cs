using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Litle_Util
{
    public partial class Form3 : Form
    {
        Form1 form;
        public Form6 form6;
        public Form3(Form1 form)
        {
            this.form = form;
            form6 = new Form6(this);
            InitializeComponent();
        }

        public void Add_Pic_Box(Hero hero, int x, int y, String prefix, EventHandler e)
        {
            Add_Pic_Box(hero, x, y, prefix, e, null, null);
        }
        public void Add_Pic_Box(Hero hero, int x, int y, String prefix, 
            EventHandler e,EventHandler e2,EventHandler e3)
        {
            PictureBox pic = new PictureBox();
            pic.BackgroundImage = hero.Image;
            pic.Location = new Point(x, y);
            pic.Size = new Size(Litle_Util.Properties.Settings.Default.IconSize, Litle_Util.Properties.Settings.Default.IconSize);
            pic.BackgroundImageLayout = ImageLayout.Zoom;
            pic.Tag = hero.Code;
            pic.Name = hero.Key + prefix;
            pic.Click += new System.EventHandler(e);
            if(e2 != null)
            {
                pic.MouseEnter += new System.EventHandler(e2);
                pic.MouseLeave += new System.EventHandler(e3);
            }
            else
            {
                pic.MouseEnter += new System.EventHandler(Mouse_Enter);
                pic.MouseLeave += new System.EventHandler(Mouse_Leave);
            }
            this.Controls.Add(pic);
        }

        public void Remove_Control()
        {
            for (int i = this.Controls.Count - 1; i >= 0; i--)
            {
                if (this.Controls[i].GetType().ToString().Equals("System.Windows.Forms.PictureBox"))
                {
                    this.Controls.Remove(this.Controls[i]);
                }
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            this.Location = new Point(this.form.Location.X, this.form.Location.Y + 30);
            this.Size = new Size(Litle_Util.Properties.Settings.Default.IconSize * 10 + 10, Litle_Util.Properties.Settings.Default.IconSize * 9);
            this.TopMost = Litle_Util.Properties.Settings.Default.TopMost;
            this.Opacity = Litle_Util.Properties.Settings.Default.Opacity;
        }

        public void Add_Pic_Box(AttrFilter.Node node, int x, int y, String prefix,
            EventHandler e, EventHandler e2, EventHandler e3)
        {
            PictureBox pic = new PictureBox();
            pic.BackgroundImage = node.image;
            pic.Location = new Point(x, y);
            pic.Size = new Size(Litle_Util.Properties.Settings.Default.IconSize, Litle_Util.Properties.Settings.Default.IconSize);
            pic.BackgroundImageLayout = ImageLayout.Zoom;
            pic.Click += new EventHandler(e);
            pic.MouseEnter += new EventHandler(e2);
            pic.MouseLeave += new EventHandler(e3);
            pic.Tag = node.msg;
            this.Controls.Add(pic);
        }

        bool flag = true;
        private void On_VisibleChanged(object sender, EventArgs e)
        {
            if (flag)
                this.form.chooseMatchObserver.Parser();
            else
                form6.Hide();
            flag = !flag;
        }

        private void Mouse_Enter(object sender, EventArgs e)
        {
            this.Opacity = 1;
        }

        private void Mouse_Leave(object sender, EventArgs e)
        {
            this.Opacity = Litle_Util.Properties.Settings.Default.Opacity;
        }
        public void Show_ToolTip(object sender, EventArgs e)
        {
            PictureBox pic = (PictureBox)sender;

            this.toolTip1.ToolTipTitle = "";
            this.toolTip1.IsBalloon = false;
            this.toolTip1.UseFading = true;
            this.toolTip1.Show(pic.Tag + "", pic);

            this.Opacity = 1;
        }
        public void Hide_ToolTip(object sender, EventArgs e)
        {
            this.toolTip1.Hide((PictureBox)sender);

            this.Opacity = Litle_Util.Properties.Settings.Default.Opacity;
        }
    }
}

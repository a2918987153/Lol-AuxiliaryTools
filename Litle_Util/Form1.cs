using System;
using System.Windows.Forms;
using System.Drawing;

namespace Litle_Util
{
    public partial class Form1 : Form
    {
        Form2 form2 ;
        Form3 form3 ;
        Form4 form4 ;
        Form5 form5 ;
        
        Form current;
        public ChooseMatchObserver chooseMatchObserver = null;
        public HeroPoolObserver heroPoolObserver = null;
        public CurrentAttrObserver currentAttrObserver = null;
        public FightObserver fightObserver = null;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            form2 = new Form2(this);
            form3 = new Form3(this);
            form4 = new Form4(this);
            form5 = new Form5(this);

            chooseMatchObserver = new ChooseMatchObserver(form3);
            heroPoolObserver = new HeroPoolObserver(form2);
            currentAttrObserver = new CurrentAttrObserver(form2);
            fightObserver = new FightObserver(form2);

            this.TopMost = Litle_Util.Properties.Settings.Default.TopMost;
            this.Opacity = Litle_Util.Properties.Settings.Default.Opacity;
            this.是否最前端显示ToolStripMenuItem.Checked = Litle_Util.Properties.Settings.Default.TopMost;
            this.锁定位置ToolStripMenuItem.Checked = Litle_Util.Properties.Settings.Default.Lock;
            this.Location = new Point(Litle_Util.Properties.Settings.Default.LocationX, Litle_Util.Properties.Settings.Default.LocationY);

            this.toolStripMenuItem2.Click += new EventHandler(toolStripMenuOpacity_Click);
            this.toolStripMenuItem3.Click += new EventHandler(toolStripMenuOpacity_Click);
            this.toolStripMenuItem4.Click += new EventHandler(toolStripMenuOpacity_Click);
            this.toolStripMenuItem5.Click += new EventHandler(toolStripMenuOpacity_Click);
            this.toolStripMenuItem6.Click += new EventHandler(toolStripMenuOpacity_Click);
            this.toolStripMenuItem7.Click += new EventHandler(toolStripMenuOpacity_Click);
            this.toolStripMenuItem8.Click += new EventHandler(toolStripMenuOpacity_Click);
            this.toolStripMenuItem9.Click += new EventHandler(toolStripMenuOpacity_Click);

            this.toolStripMenuItem10.Click += new EventHandler(toolStripMenuIconSize_Click);
            this.toolStripMenuItem11.Click += new EventHandler(toolStripMenuIconSize_Click);
            this.toolStripMenuItem12.Click += new EventHandler(toolStripMenuIconSize_Click);

            //this.button5.MouseClick += new MouseEventHandler(button1_Click);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //f2.Dock = DockStyle.Fill;
            if (current != null)
            {
                current.Hide();
            }
            form2.Show();
            current = form2;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (current != null)
            {
                current.Hide();
            }
            form3.Show();
            current = form3;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (current != null)
            {
                current.Hide();
            }
            form4.Show();
            current = form4;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (current != null)
            {
                current.Hide();
            }
            form5.Show();
            current = form5;
        }
        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form7 form7 = new Form7();
            form7.Show();
        }

        private void 是否最前端显示ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem toolStripMenuItem = (ToolStripMenuItem)sender;

            this.TopMost = toolStripMenuItem.Checked;
            form2.TopMost = toolStripMenuItem.Checked;
            form3.TopMost = toolStripMenuItem.Checked;
            form4.TopMost = toolStripMenuItem.Checked;
            form5.TopMost = toolStripMenuItem.Checked;

            Litle_Util.Properties.Settings.Default.TopMost = toolStripMenuItem.Checked;
            Litle_Util.Properties.Settings.Default.Save();
        }

        private void toolStripMenuOpacity_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem tool = (ToolStripMenuItem)sender;

            this.Opacity = Convert.ToDouble(tool.Text);
            form2.Opacity = Convert.ToDouble(tool.Text);
            form3.Opacity = Convert.ToDouble(tool.Text);
            form4.Opacity = Convert.ToDouble(tool.Text);
            form5.Opacity = Convert.ToDouble(tool.Text);

            Litle_Util.Properties.Settings.Default.Opacity = Convert.ToDouble(tool.Text);
            Litle_Util.Properties.Settings.Default.Save();
        }

        private void toolStripMenuIconSize_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem tool = (ToolStripMenuItem)sender;
            Litle_Util.Properties.Settings.Default.IconSize = Convert.ToInt32(tool.Text);
            Litle_Util.Properties.Settings.Default.Save();
            MessageBox.Show("修改后最好重启一下");
        }

        Point p;

        private void button1_MouseDown(object sender, MouseEventArgs e)
        {
            p = e.Location;
            if (e.Button == MouseButtons.Right)
            {
                if (current != null)
                {
                    current.Hide();
                }
            }
        }

        private void button1_MouseUp(object sender, MouseEventArgs e)
        {
            p = e.Location;
            Reset_Location();
        }

        private void Reset_Location()
        {
            form2.Location = new Point(this.Location.X, this.Location.Y + 30);
            form3.Location = new Point(this.Location.X, this.Location.Y + 30);
            form4.Location = new Point(this.Location.X, this.Location.Y + 30);
            form5.Location = new Point(this.Location.X, this.Location.Y + 30);
            form2.form6.Location = new Point(this.form2.Location.X + this.form2.Size.Width,
                this.form2.Location.Y);
            form3.form6.Location = new Point(this.form3.Location.X + this.form3.Size.Width,
                this.form3.Location.Y);

            Litle_Util.Properties.Settings.Default.LocationX = this.Location.X;
            Litle_Util.Properties.Settings.Default.LocationY = this.Location.Y;
            Litle_Util.Properties.Settings.Default.Save();
        }

        private void button1_MouseMove(object sender, MouseEventArgs e)
        {
            if (!Litle_Util.Properties.Settings.Default.Lock)
            {
                if (e.Button == System.Windows.Forms.MouseButtons.Left)
                    this.Location = new Point(this.Left + (e.X - p.X), this.Top + (e.Y - p.Y));
            }
        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void 锁定位置ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem tool = (ToolStripMenuItem)sender;
            Litle_Util.Properties.Settings.Default.Lock = tool.Checked;
            Litle_Util.Properties.Settings.Default.Save();
        }

        private void Bbutton1_MouseClick(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Right)
            {
                if(current != null)
                {
                    current.Hide();
                }
            }
        }
    }
}

using System;
using System.Drawing;
using System.Windows.Forms;

namespace Litle_Util
{
    public partial class Form2 : Form
    {
        
        int key = 0;
        Form1 form;
        public Form6 form6;
        public int people = 0;
        public Form2(Form1 form)
        {
            this.form = form;
            this.form6 = new Form6(this);
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            int count = 0;
            foreach (String heroKey in Global.TABLE.Keys)
            {
                initdesk(heroKey, count);
                count++;
            }
            this.Size = new Size(Litle_Util.Properties.Settings.Default.IconSize * 10 + 10, Litle_Util.Properties.Settings.Default.IconSize * 9);
            this.Location = new Point(this.form.Location.X, this.form.Location.Y + 30);
            this.label1.Location = new Point(0, Litle_Util.Properties.Settings.Default.IconSize * 6 + 10);
            this.TopMost = Litle_Util.Properties.Settings.Default.TopMost;
            this.Opacity = Litle_Util.Properties.Settings.Default.Opacity;
        }
        private void initdesk(String heroKey, int i)
        {
            int width = Litle_Util.Properties.Settings.Default.IconSize;
            int height = Litle_Util.Properties.Settings.Default.IconSize;

            int x = i % 10 * width;
            int y = i / 10 * height;

            Hero hero = HeroFactory.create(heroKey);
            hero.Key = ++key;
            hero.Level = 1;
            Add_Pic_Box(hero, x, y, "Init", Pic_Click, Mouse_Enter,Mouse_Leave);
        }

        private void Pic_Click(object sender, EventArgs e)
        {
            PictureBox pic = (PictureBox)sender;
            MouseEventArgs Mouse_e = (MouseEventArgs)e;
            if (Mouse_e.Button == MouseButtons.Left)
            {
                String str = (String)pic.Tag;
                Hero hero = HeroFactory.create(str);
                hero.Key = ++key;
                hero.Level = 1;
                hero.Attach(this.form.chooseMatchObserver);
                hero.Attach(this.form.heroPoolObserver);
                hero.Attach(this.form.currentAttrObserver);
                hero.Attach(this.form.fightObserver);
                hero.Get();
                people++;
            }
            else
            {
                Hero hero = HeroFactory.create(pic.Tag + "");
                this.form6.Add_Rec_Pic_Box(hero);
                if (this.form6.Visible == false)
                {
                    this.form6.Show();
                }
            }
        }

        public void Add_Pic_Box(Hero hero, int x, int y, String prefix,EventHandler e)
        {
            Add_Pic_Box(hero,x,y,prefix,e,null,null);
        }
        public void Add_Pic_Box(Hero hero, int x, int y, String prefix, 
            EventHandler e, EventHandler e2, EventHandler e3)
        {
            PictureBox pic = new PictureBox();
            pic.BackgroundImage = hero.Image;
            pic.Location = new Point(x, y);
            pic.Size = new Size(
                Litle_Util.Properties.Settings.Default.IconSize + (hero.Level - 1) * 10, 
                Litle_Util.Properties.Settings.Default.IconSize + (hero.Level - 1) * 10
            );
            pic.BackgroundImageLayout = ImageLayout.Zoom;
            pic.Tag = hero.Code;
            pic.Name = hero.Key + prefix;
            pic.MouseClick += new MouseEventHandler(e);
            if(e2 != null)
            {
                pic.MouseEnter += new EventHandler(e2);
                pic.MouseLeave += new EventHandler(e3);
            }

            this.Controls.Add(pic);
        }

        public void Add_Pic_Box(AttrFilter.Node node, int x, int y, String prefix,
            EventHandler e, EventHandler e2, EventHandler e3)
        {
            PictureBox pic = new PictureBox();
            pic.BackgroundImage = node.image;
            pic.Location = new Point(x, y);
            pic.Size = new Size(Litle_Util.Properties.Settings.Default.IconSize, Litle_Util.Properties.Settings.Default.IconSize);
            pic.BackgroundImageLayout = ImageLayout.Zoom;
            pic.Name = node.key + prefix;
            pic.Click += new EventHandler(e);
            pic.MouseEnter += new EventHandler(e2);
            pic.MouseLeave += new EventHandler(e3);
            pic.Tag = node.msg;
            this.Controls.Add(pic);
        }

        public void Remove_Pic_Box(String key)
        {
            this.Controls.RemoveByKey(key);
        }
        public void Set_Label_Text(int fight)
        {
            this.label1.Text = "战斗力：" + fight;
        }

        public void Show_ToolTip(object sender, EventArgs e)
        {
            PictureBox pic = (PictureBox)sender;
            String str = (String)pic.Tag;
            Hero hero = HeroFactory.create(str);

            this.toolTip1.ToolTipTitle = "爆率：";
            this.toolTip1.IsBalloon = false;
            this.toolTip1.UseFading = true;
            this.toolTip1.Show(Global.Rate[people-1, hero.Cost-1], pic);

            this.Opacity = 1;
        }
        public void Hide_ToolTip(object sender, EventArgs e)
        {
            this.toolTip1.Hide((PictureBox)sender);

            this.Opacity = Litle_Util.Properties.Settings.Default.Opacity;
        }
        public void Show_Node_ToolTip(object sender, EventArgs e)
        {
            PictureBox pic = (PictureBox)sender;

            this.toolTip1.ToolTipTitle = "";
            this.toolTip1.IsBalloon = false;
            this.toolTip1.UseFading = true;
            this.toolTip1.Show(pic.Tag + "", pic);

            this.Opacity = 1;
        }

        private void Mouse_Enter(object sender, EventArgs e)
        {
            this.Opacity = 1;
        }

        private void Mouse_Leave(object sender, EventArgs e)
        {
            this.Opacity = Litle_Util.Properties.Settings.Default.Opacity;
        }

        bool flag = true;
        private void Visible_Changed(object sender, EventArgs e)
        {
            if (!flag)
                form6.Hide();
            flag = !flag;
        }
    }
}

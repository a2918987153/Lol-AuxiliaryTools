using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Text;

namespace Litle_Util
{
    public partial class Form5 : Form
    {
        Form1 form;
        public HashSet<HeroType> set = new HashSet<HeroType>();
        List<List<Hero>> formatter = new List<List<Hero>>();
        public Form5(Form1 form)
        {
            this.form = form;
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            this.Location = new Point(this.form.Location.X, this.form.Location.Y + 30);
            this.Size = new Size(Litle_Util.Properties.Settings.Default.IconSize * 10 + 10, Litle_Util.Properties.Settings.Default.IconSize * 9);
            this.TopMost = Litle_Util.Properties.Settings.Default.TopMost;
            this.Opacity = Litle_Util.Properties.Settings.Default.Opacity;

            this.checkBox1.Click += new EventHandler(Check_Click);
            this.checkBox2.Click += new EventHandler(Check_Click);
            this.checkBox3.Click += new EventHandler(Check_Click);
            this.checkBox4.Click += new EventHandler(Check_Click);
            this.checkBox5.Click += new EventHandler(Check_Click);
            this.checkBox6.Click += new EventHandler(Check_Click);
            this.checkBox7.Click += new EventHandler(Check_Click);
            this.checkBox8.Click += new EventHandler(Check_Click);
            this.checkBox9.Click += new EventHandler(Check_Click);
            this.checkBox10.Click += new EventHandler(Check_Click);
            this.checkBox11.Click += new EventHandler(Check_Click);
            this.checkBox12.Click += new EventHandler(Check_Click);
            this.checkBox13.Click += new EventHandler(Check_Click);
            this.checkBox14.Click += new EventHandler(Check_Click);
            this.checkBox15.Click += new EventHandler(Check_Click);
            this.checkBox16.Click += new EventHandler(Check_Click);
            this.checkBox17.Click += new EventHandler(Check_Click);
            this.checkBox18.Click += new EventHandler(Check_Click);
            this.checkBox19.Click += new EventHandler(Check_Click);
            this.checkBox20.Click += new EventHandler(Check_Click);
            this.checkBox21.Click += new EventHandler(Check_Click);
            this.checkBox22.Click += new EventHandler(Check_Click);
            this.checkBox23.Click += new EventHandler(Check_Click);
        }
        private void Check_Click(object sender, EventArgs e)
        {
            CheckBox checkBox = (CheckBox)sender;
            if (checkBox.Checked)
            {
                set.Add((HeroType)Global.Hero_Table[checkBox.Tag]);
            }
            else
            {
                set.Remove((HeroType)Global.Hero_Table[checkBox.Tag]);
            }
            Match_Hero();
            Remove_Control();
            Add_Pic_Box();
        }

        private void Match_Hero()
        {
            StreamReader sr = new StreamReader("Data.txt", Encoding.Default);  //path为文件路径
            String line;
            int bracher = 0;
            formatter.Clear();
            while ((line = sr.ReadLine()) != null)//按行读取 line为每行的数据
            {
                if (bracher % 2 == 0)
                {
                    List<Hero> list = new List<Hero>();
                    String[] strs = line.Split(new char[1] { ',' });
                    HashSet<String> srcSet = new HashSet<string>(strs);

                    List<Hero> tempList = new List<Hero>();
                    foreach (String tempStr in strs)
                    {
                        tempList.Add(HeroFactory.create(tempStr));
                    }

                    AttrFilter attrFilter = new AttrFilter();

                    foreach (Hero hero in tempList)
                    {
                        attrFilter.Filter(hero);
                    }
                    List<AttrFilter.Node> nodes = attrFilter.Fecth();
                    HashSet<HeroType> resultSet = new HashSet<HeroType>();
                   
                    foreach (AttrFilter.Node tempNode in nodes)
                    {
                        resultSet.Add(tempNode.heroType);
                    }

                    if (set.IsSubsetOf(resultSet))
                    {
                        formatter.Add(tempList);
                    }
                }
                else if (bracher % 2 == 1)
                {

                }
                bracher++;
            }
        }
        private void Add_Pic_Box()
        {
            int y = 200;
            foreach (List<Hero> hero_list in formatter){
                Add_Pic_Box(hero_list,y);
                y += Litle_Util.Properties.Settings.Default.IconSize + 10;
            }
        }
        private void Add_Pic_Box(List<Hero> hero_list,int y)
        {
            int x = 0;
            foreach (Hero hero in hero_list)
            {
                Add_Pic_Box(hero, x,y);
                x += Litle_Util.Properties.Settings.Default.IconSize;
            }
        }
        public void Add_Pic_Box(Hero hero, int x, int y)
        {
            PictureBox pic = new PictureBox();
            pic.BackgroundImage = hero.Image;
            pic.Location = new Point(x, y);
            pic.Size = new Size(Litle_Util.Properties.Settings.Default.IconSize, Litle_Util.Properties.Settings.Default.IconSize);
            pic.BackgroundImageLayout = ImageLayout.Zoom;
            this.Controls.Add(pic);
        }
        private void Remove_Control()
        {
            for (int i = this.Controls.Count - 1;i >= 0; i--)
            {
                if (this.Controls[i].GetType().ToString().Equals("System.Windows.Forms.PictureBox"))
                {
                    this.Controls.Remove(this.Controls[i]);
                }
            }
        }

    }
}

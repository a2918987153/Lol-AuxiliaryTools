using System;
using System.Collections.Generic;
using System.Collections;
using System.Windows.Forms;
using System.Text;
using System.IO;

namespace Litle_Util
{
    public partial class Form7 : Form
    {
        HashSet<String> set = new HashSet<string>();
        public Form7()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Match_Hero_Exist())
            {
                MessageBox.Show("已存在的阵容");
                return;
            }
            using (System.IO.StreamWriter file = new System.IO.StreamWriter("Data.txt", true))
            {
                String line = "";
                foreach (String str in set)
                {
                    if(line.Length > 0)
                    {
                        line += ",";
                    }
                    line += str;
                }
                file.WriteLine("");
                file.WriteLine(line);
                file.WriteLine(this.textBox1.Text);
            }
            MessageBox.Show("保存完成");
            foreach (Control control in this.Controls)
            {
                if (control.GetType().ToString().Equals("System.Windows.Forms.CheckBox"))
                {
                    CheckBox checkBox = (CheckBox)control;
                    checkBox.Checked = false;
                }
            }
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            foreach(Control control in this.Controls)
            {
                if (control.GetType().ToString().Equals("System.Windows.Forms.CheckBox"))
                {
                    control.Click += new EventHandler(Check_Click);
                }
            }
        }
        private void Check_Click(object sender, EventArgs e)
        {
            CheckBox checkBox = (CheckBox)sender;
            if (checkBox.Checked)
            {
                set.Add(checkBox.Tag + "");
            }
            else
            {
                set.Remove(checkBox.Tag + "");
            }
            Macth_HeroType();
        }
        private void Macth_HeroType()
        {
            List<Hero> hero_list = new List<Hero>();
            foreach(String code in set)
            {
                Hero hero = HeroFactory.create(code);
                hero_list.Add(hero);
            }

            Hashtable hashTable = new Hashtable();

            foreach(Hero hero in hero_list)
            {
                foreach(HeroType heroType in hero.TypeCodes)
                {
                    if (hashTable.Contains(heroType))
                    {
                        int count = (int)hashTable[heroType];
                        count++;
                        hashTable[heroType] = count;
                    }
                    else
                    {
                        hashTable.Add(heroType, 1);
                    }
                }
            }
            String str = "";
            foreach(DictionaryEntry de in hashTable)
            {
                if (str.Length > 0)
                    str += ",";
                str += Global.Type_Name[de.Key] + ":(" + de.Value + ")";
            }

            this.label2.Text = "羁绊：" + str;
        }

        private bool Match_Hero_Exist()
        {
            using (StreamReader sr = new StreamReader("Data.txt", Encoding.Default))   //path为文件路径
            {
                String line;
                int bracher = 0;
                while ((line = sr.ReadLine()) != null)//按行读取 line为每行的数据
                {
                    if (bracher % 2 == 0)
                    {
                        String[] str = line.Split(new char[1] { ',' });
                        HashSet<String> srcSet = new HashSet<string>(str);
                        bool flag = true;
                        foreach (String temp in srcSet)
                        {
                            if (!set.Contains(temp))
                            {
                                flag = false;
                            }
                        }
                        if (flag && srcSet.Count == set.Count)
                        {
                            return true;
                        }
                    }
                    else if (bracher % 2 == 1)
                    {

                    }
                    bracher++;
                }
            }
               
            return false;
        }
    }
}

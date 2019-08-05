using System;
using System.Text;
using System.IO;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Litle_Util
{
    public class ChooseMatchObserver : Observer
    {
        int y = 0;
        LinkStack<Hero> linkStack = null;
        Form3 form;

        public ChooseMatchObserver(Form3 form)
        {
            this.form = form;
        }

        public void Parser()
        {
            y = 0;
            this.form.Remove_Control();
            Match_Hero();
            Pic_Match_Add(linkStack);
        }

        public override void Reset(Hero hero)
        {
            if (hero.State == 1)
            {
                hero_list.Add(hero);
            }
            else
            {
                hero_list.Remove(hero);
            }
        }
        private void Pic_Match_Add(LinkStack<Hero> linkStack)
        {
            LinkStack<Hero> replaceStack = linkStack;
            int i = 0;
            while (replaceStack.Next != null || replaceStack.Head != null)
            {
                LinkStack<Hero> temp = replaceStack.Next;

                this.form.Add_Pic_Box(temp.Node, i * Litle_Util.Properties.Settings.Default.IconSize, y, "Match", Pic_Match_Click);

                i++;
                if (temp.Next != null)
                {
                    replaceStack = temp;
                }
                else if (temp.Head != null)
                {
                    replaceStack = temp.Head;
                    int count = 0;
                    foreach (AttrFilter.Node node in replaceStack.Nodes)
                    {
                        this.form.Add_Pic_Box(node, count * Litle_Util.Properties.Settings.Default.IconSize, y + Litle_Util.Properties.Settings.Default.IconSize + 10, "CurrentAttr", Pic_Match_Click, this.form.Show_ToolTip, this.form.Hide_ToolTip);
                        count++;
                    }
                    AttrFilter.Node describe = new AttrFilter.Node(HeroType.Assassin, 0, 0, replaceStack.Msg, Properties.Resources.TiersIcon);
                    this.form.Add_Pic_Box(describe, 8 * Litle_Util.Properties.Settings.Default.IconSize, y + Litle_Util.Properties.Settings.Default.IconSize + 10, "CurrentAttr", Pic_Info_Click, this.form.Show_ToolTip, this.form.Hide_ToolTip);
                    y += Litle_Util.Properties.Settings.Default.IconSize * 2 + 20;
                    i = 0;
                }
            }
        }

        private void Match_Hero()
        {
            linkStack = new LinkStack<Hero>();
            LinkStack<Hero> replaceStack = linkStack;

            using (StreamReader sr = new StreamReader("Data.txt", Encoding.Default))   //path为文件路径
            {
                String line;
                int bracher = 0;
                while ((line = sr.ReadLine()) != null)//按行读取 line为每行的数据
                {
                    if (bracher % 2 == 0)
                    {
                        List<Hero> list = new List<Hero>();
                        String[] str = line.Split(new char[1] { ',' });
                        HashSet<String> srcSet = new HashSet<string>(str);
                        HashSet<String> tarSet = new HashSet<string>();

                        foreach (Hero temp in hero_list)
                        {
                            tarSet.Add(temp.Code);
                        }

                        if (Global.compute1(srcSet, tarSet))
                        {
                            setNext(ref replaceStack, srcSet);
                            setNodes(srcSet, replaceStack);
                            bracher = 0;
                        }
                    }
                    else if (bracher % 2 == 1)
                    {
                        if (bracher == 1)
                            replaceStack.Msg = line;
                    }
                    bracher++;
                }
            }
        }

        private void setNodes(HashSet<String> srcSet, LinkStack<Hero> replaceStack)
        {
            List<Hero> heros = new List<Hero>();
            foreach (String str in srcSet)
            {
                Hero temp = HeroFactory.create(str);
                heros.Add(temp);
            }
            AttrFilter attrFilter = new AttrFilter();

            foreach (Hero hero in heros)
            {
                attrFilter.Filter(hero);
            }
            List<AttrFilter.Node> nodes = attrFilter.Fecth();
            replaceStack.Nodes = nodes;
        }

        private void setNext(ref LinkStack<Hero> replaceStack, HashSet<String> hSet)
        {

            foreach (String str in hSet)
            {
                Hero temp = HeroFactory.create(str);
                LinkStack<Hero> node = new LinkStack<Hero>();
                node.Node = temp;
                replaceStack.Next = node;
                replaceStack = node;
            }
            LinkStack<Hero> head = new LinkStack<Hero>();
            replaceStack.Head = head;
            replaceStack = replaceStack.Head;
        }

        private void Pic_Match_Click(object sender, EventArgs e)
        {
            PictureBox pic = (PictureBox)sender;
            Hero hero = HeroFactory.create(pic.Tag + "");
            this.form.form6.Add_Rec_Pic_Box(hero);
            if(this.form.form6.Visible == false)
            {
                this.form.form6.Show();
            }
        }
        private void Pic_Info_Click(object sender, EventArgs e)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Litle_Util
{
    public class CurrentAttrObserver : Observer
    {
        Form2 form;
        List<AttrFilter.Node> nodes;
        int key = 0;
        public CurrentAttrObserver(Form2 form)
        {
            this.form = form;
        }
        public override void Reset(Hero hero)
        {
            Pic_Current_Attr_Remove();
            if (hero.State == 1)
            {
                hero_list.Add(hero);
            }
            else
            {
                hero_list.Remove(hero);
            }
            Draw_Attr_Pic();
        }
        private void Draw_Attr_Pic()
        {
            AttrFilter attrFilter = new AttrFilter();

            foreach (Hero hero in hero_list)
            {
                attrFilter.Filter(hero);
            }
            nodes = attrFilter.Fecth();

            int count = 0;
            foreach(AttrFilter.Node node in nodes)
            {
                node.key = ++ key;
                this.form.Add_Pic_Box(node, count * Litle_Util.Properties.Settings.Default.IconSize,
                    Litle_Util.Properties.Settings.Default.IconSize * 8, "CurrentAttr", Pic_Current_Attr_Click,this.form.Show_Node_ToolTip,this.form.Hide_ToolTip);
                count ++;
            }
        }
        public void Pic_Current_Attr_Remove()
        {
            if (nodes == null)
            {
                return;
            }
            foreach(AttrFilter.Node node in nodes)
            {
                this.form.Remove_Pic_Box(node.key + "CurrentAttr");
            }
        }
        public void Pic_Current_Attr_Click(object sender, EventArgs e)
        {

        }
    }
}

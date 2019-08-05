using System;
using System.Windows.Forms;

namespace Litle_Util
{
    public class HeroPoolObserver : Observer
    {
        Form2 form;
        public HeroPoolObserver(Form2 form)
        {
            this.form = form;
        }
        
        public override void Reset(Hero hero)
        {
            Pic_Current_Remove();
            if (hero.State == 1)
            {
                hero_list.Add(hero);
            }
            else
            {
                hero_list.Remove(hero);
            }
            Pic_Current_Add();
        }

        private void Pic_Current_Add()
        {
            int offset = 0;
            for (int i = 0; i < hero_list.Count; i++)
            {
                this.form.Add_Pic_Box(hero_list[i], i * Litle_Util.Properties.Settings.Default.IconSize + offset, Litle_Util.Properties.Settings.Default.IconSize * 6 + 20, "Current", Pic_Current_Click, this.form.Show_ToolTip, this.form.Hide_ToolTip);
                offset += (hero_list[i].Level - 1) * 10;
            }

        }

        private void Pic_Current_Remove()
        {
            for (int i = 0; i < hero_list.Count; i++)
            {
                this.form.Remove_Pic_Box(hero_list[i].Key + "Current");
            }
        }

        private void Pic_Current_Click(object sender, EventArgs e)
        {
            PictureBox pic = (PictureBox)sender;
            String str = (String)pic.Tag;

            MouseEventArgs Mouse_e = (MouseEventArgs)e;
            if (Mouse_e.Button == MouseButtons.Left)
            {
                for (int i = 0; i < hero_list.Count; i++)
                {
                    if (hero_list[i].Code.Equals(str))
                    {
                        hero_list[i].Remove();
                        this.form.people --;
                    }
                }
            }
            else if (Mouse_e.Button == MouseButtons.Right)
            {
                foreach(Hero hero in hero_list)
                {
                    if (hero.Code.Equals(str))
                    {
                        if(hero.Level == 3)
                        {
                            return;
                        }
                        else
                        {
                            hero.Level += 1;
                            hero.Remove();
                            hero.Get();
                            return;
                        }
                    }
                }
            }
        }
    }
}

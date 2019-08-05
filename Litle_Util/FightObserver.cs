using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Litle_Util
{
    public class FightObserver : Observer
    {
        Form2 form;
        public FightObserver(Form2 form)
        {
            this.form = form;
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
            FetchFight();
        }
        private void FetchFight()
        {
            int fight = 0;
            foreach(Hero hero in hero_list)
            {
                fight += hero.Level * 50;
            }
            this.form.Set_Label_Text(fight);
        }
    }
}

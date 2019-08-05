using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Litle_Util
{
    public abstract class Observer
    {
        protected List<Hero> hero_list = new List<Hero>();

        abstract public void Reset(Hero hero);
    }
}

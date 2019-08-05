using System;
using System.Collections.Generic;
using System.Drawing;
using System.Collections;

namespace Litle_Util
{
    public class AttrFilter
    {

        public Hashtable table = new Hashtable();
        public HashSet<String> set = new HashSet<String>();

        public void Filter(Hero hero)
        {
            if (set.Contains(hero.Code))
            {
                return;
            }
            foreach (HeroType heroType in hero.TypeCodes)
            {
                if (table.ContainsKey(heroType))
                {
                    int count = (int)table[heroType];
                    count++;
                    table[heroType] = count;
                }
                else
                {
                    table.Add(heroType, 1);
                }
            }
            set.Add(hero.Code);
        }

        public List<Node> Fecth()
        {
            List<Node> result = new List<Node>();
            foreach(DictionaryEntry de in table)
            {
                foreach(Node node in Global.Nodes)
                {
                    if(node.heroType == (HeroType)de.Key)
                    {
                        if((int)de.Value >= node.minCount && (int)de.Value < node.maxCount)
                        {
                            node.msg = node.msg.Replace("{0}", de.Value + "").Replace("{1}", node.maxCount + "");
                            result.Add(node);
                        }
                    }
                }
            }
            return result;
        }

        public class Node
        {
            public Node(HeroType heroType, int minCount, int maxCount, String msg, Bitmap image)
            {
                this.heroType = heroType;
                this.minCount = minCount;
                this.maxCount = maxCount;
                this.msg = msg;
                this.image = image;
            }
            public HeroType heroType;
            public int minCount;
            public int maxCount;
            public String msg;
            public Bitmap image;
            public int key;
        }

    }

    
}

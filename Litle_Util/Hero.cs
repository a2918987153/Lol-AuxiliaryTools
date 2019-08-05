using System;
using System.Collections.Generic;
using System.Drawing;

namespace Litle_Util
{
    public abstract class Hero : Subject
    {
        protected String code;
        protected Bitmap image;
        protected List<HeroType> typeCodes = new List<HeroType>();

        protected int level;
        protected int cost;
        protected int armor;
        protected int magicResistance;
        protected int hurt;
        protected int attackSpeed;
        protected int attackDistance;
        protected int perSecondHurt;
        protected int headlth;
        protected int state;
        protected int key;
        protected List<Bitmap> recEqus = new List<Bitmap>();

        private List<Observer> list = new List<Observer>();

        public string Code { get => code; set => code = value; }
        public Bitmap Image { get => image; set => image = value; }
        public List<HeroType> TypeCodes { get => typeCodes; set => typeCodes = value; }
        public int Level { get => level; set => level = value; }
        public int Cost { get => cost; set => cost = value; }
        public int Armor { get => armor; set => armor = value; }
        public int MagicResistance { get => magicResistance; set => magicResistance = value; }
        public int Hurt { get => hurt; set => hurt = value; }
        public int AttackSpeed { get => attackSpeed; set => attackSpeed = value; }
        public int AttackDistance { get => attackDistance; set => attackDistance = value; }
        public int PerSecondHurt { get => perSecondHurt; set => perSecondHurt = value; }
        public int Headlth { get => headlth; set => headlth = value; }
        public int State { get => state; set => state = value; }
        public int Key { get => key; set => key = value; }
        public List<Bitmap> RecEqus { get => recEqus; set => recEqus = value; }

        public void Get()
        {
            this.State = 1;
            Notify();
        }
        public void Remove()
        {
            this.State = 0;
            Notify();
        }
        public void Attach(Observer observer)
        {
            this.list.Add(observer);
        }

        public void Detach(Observer observer)
        {
            throw new NotImplementedException();
        }

        public void Notify()
        {
            foreach (Observer o in list)
            {
                o.Reset(this);
            }
        }


    }
}

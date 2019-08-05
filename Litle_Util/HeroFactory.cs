using System;

namespace Litle_Util
{
    public class HeroFactory
    {
        

        public static Hero create(String code)
        {
            String heroClass = (String)Global.TABLE[code];
            Type type = Type.GetType(heroClass, false, true);
            object obj = System.Activator.CreateInstance(type);
            return (Hero) obj;
        }

    }
}

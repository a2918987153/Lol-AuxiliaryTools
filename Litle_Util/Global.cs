using System;
using System.Collections;
using System.Collections.Generic;

namespace Litle_Util
{
    public class Global
    {

        public static String[,] Rate = new String[9,5]{
            {"100%","0%","0%","0%","0%"},
            {"100%","0%","0%","0%","0%"},
            {"70%","30%","0%","0%","0%"},
            {"55%","30%","15%","0%","0%"},
            {"40%","30%","25%","5%","0%"},
            {"29%","29.5%","31%","10%","0.5%"},
            {"24%","28%","31%","15%","2%"},
            {"20%","24%","31%","20%","5%"},
            {"10%","19%","31%","30%","10%"}
        };
        public static AttrFilter.Node[] Nodes = {
            //new AttrFilter.Node(HeroType.Assassin,0,3,"刺客们会获得额外的暴击伤害\t\n{0}/{1}\t",Properties.Resources.Pro_assassin),
            new AttrFilter.Node(HeroType.Assassin,3,6,"刺客们会获得额外的暴击伤害\t\n{0}/{1}\t暴击伤害+150%",Properties.Resources.Pro_assassin),
            new AttrFilter.Node(HeroType.Assassin,6,99,"刺客们会获得额外的暴击伤害\t\n{0}/{1}\t暴击伤害+350%",Properties.Resources.Pro_assassin),
            //new AttrFilter.Node(HeroType.Blademaster,0,3,"剑士们的每次攻击有45%几率打出一定次数的额外攻击\t\n{0}/{1}\t",Properties.Resources.Pro_blademaster),
            new AttrFilter.Node(HeroType.Blademaster,3,6,"剑士们的每次攻击有45%几率打出一定次数的额外攻击\t\n{0}/{1}\t1次额外攻击",Properties.Resources.Pro_blademaster),
            new AttrFilter.Node(HeroType.Blademaster,6,99,"剑士们的每次攻击有45%几率打出一定次数的额外攻击\t\n{0}/{1}\t2次额外攻击",Properties.Resources.Pro_blademaster),
            //new AttrFilter.Node(HeroType.Brawler,0,3,"斗士获得额外的最大生命值\t\n{0}/{1}\t",Properties.Resources.Pro_brawler),
            new AttrFilter.Node(HeroType.Brawler,3,6,"斗士获得额外的最大生命值\t\n{0}/{1}\t300额外生命值",Properties.Resources.Pro_brawler),
            new AttrFilter.Node(HeroType.Brawler,6,99,"斗士获得额外的最大生命值\t\n{0}/{1}\t700额外生命值",Properties.Resources.Pro_brawler),
            //new AttrFilter.Node(HeroType.Elementalist,0,3,"元素使们的攻击提供双倍法力值\t\n{0}/{1}\t",Properties.Resources.Pro_elementalist),
            new AttrFilter.Node(HeroType.Elementalist,3,99,"元素使们的攻击提供双倍法力值\t\n{0}/{1}\t在战斗开始时, 召唤一个魔像",Properties.Resources.Pro_elementalist),
            //new AttrFilter.Node(HeroType.Guardian,0,2,"{0}/{1}\t护卫",Properties.Resources.Pro_guardian),
            new AttrFilter.Node(HeroType.Guardian,2,99,"{0}/{1}\t在战斗开始时，所有护卫和邻近格子的友军+40护甲",Properties.Resources.Pro_guardian),
            //new AttrFilter.Node(HeroType.Gunslinger,0,2,"在攻击之后,枪手们的攻击有50%几率打出额外的攻击\t\n{0}/{1}\t",Properties.Resources.Pro_gunslinger),
            new AttrFilter.Node(HeroType.Gunslinger,2,4,"在攻击之后,枪手们的攻击有50%几率打出额外的攻击\t\n{0}/{1}\t攻击另一名随机敌人",Properties.Resources.Pro_gunslinger),
            new AttrFilter.Node(HeroType.Gunslinger,4,99,"在攻击之后,枪手们的攻击有50%几率打出额外的攻击\t\n{0}/{1}\t攻击距离内的所有其他敌人",Properties.Resources.Pro_gunslinger),
            //new AttrFilter.Node(HeroType.Knight,0,2,"骑士们格挡来自普攻的伤害\t\n{0}/{1}\t",Properties.Resources.Pro_knight),
            new AttrFilter.Node(HeroType.Knight,2,4,"骑士们格挡来自普攻的伤害\t\n{0}/{1}\t格挡20伤害",Properties.Resources.Pro_knight),
            new AttrFilter.Node(HeroType.Knight,4,6,"骑士们格挡来自普攻的伤害\t\n{0}/{1}\t格挡40伤害",Properties.Resources.Pro_knight),
            new AttrFilter.Node(HeroType.Knight,6,99,"骑士们格挡来自普攻的伤害\t\n{0}/{1}\t格挡60伤害",Properties.Resources.Pro_knight),
            //new AttrFilter.Node(HeroType.Ranger,0,2,"游侠们每3秒都有一定几率来使他们在接下来的3秒内攻速翻倍\t\n{0}/{1}\t",Properties.Resources.Pro_ranger),
            new AttrFilter.Node(HeroType.Ranger,2,4,"游侠们每3秒都有一定几率来使他们在接下来的3秒内攻速翻倍\t\n{0}/{1}\t25%几率是攻速翻倍",Properties.Resources.Pro_ranger),
            new AttrFilter.Node(HeroType.Ranger,4,99,"游侠们每3秒都有一定几率来使他们在接下来的3秒内攻速翻倍\t\n{0}/{1}\t65%几率使攻速翻倍",Properties.Resources.Pro_ranger),
            //new AttrFilter.Node(HeroType.Shapeshifter,0,3,"换形师们会在他们变形时获得额外最大生命值\t\n{0}/{1}\t",Properties.Resources.Pro_shapeshifter),
            new AttrFilter.Node(HeroType.Shapeshifter,3,99,"换形师们会在他们变形时获得额外最大生命值\t\n{0}/{1}\t100%额外最大生命值",Properties.Resources.Pro_shapeshifter),
            //new AttrFilter.Node(HeroType.Sorcerer,0,3,"法师们的攻击提供双倍魔法值友军的技能伤害得到提升\t\n{0}/{1}\t",Properties.Resources.Pro_sorcerer),
            new AttrFilter.Node(HeroType.Sorcerer,3,6,"法师们的攻击提供双倍魔法值友军的技能伤害得到提升\t\n{0}/{1}\t+35%技能伤害",Properties.Resources.Pro_sorcerer),
            new AttrFilter.Node(HeroType.Sorcerer,6,99,"法师们的攻击提供双倍魔法值友军的技能伤害得到提升\t\n{0}/{1}\t+100%技能伤害",Properties.Resources.Pro_sorcerer),
            //new AttrFilter.Node(HeroType.Demon,0,2,"恶魔的攻击有几率灼烧一名敌人所有法力值并造成等额的真实伤害\t\n{0}/{1}\t",Properties.Resources.Race_demon),
            new AttrFilter.Node(HeroType.Demon,2,4,"恶魔的攻击有几率灼烧一名敌人所有法力值并造成等额的真实伤害\t\n{0}/{1}\t40%几率灼烧法力值",Properties.Resources.Race_demon),
            new AttrFilter.Node(HeroType.Demon,4,6,"恶魔的攻击有几率灼烧一名敌人所有法力值并造成等额的真实伤害\t\n{0}/{1}\t60%几率灼烧法力值",Properties.Resources.Race_demon),
            new AttrFilter.Node(HeroType.Demon,6,99,"恶魔的攻击有几率灼烧一名敌人所有法力值并造成等额的真实伤害\t\n{0}/{1}\t80%几率灼烧法力值",Properties.Resources.Race_demon),
            //new AttrFilter.Node(HeroType.Dragon,0,2,"{0}/{1}\t龙",Properties.Resources.Race_dragon),
            new AttrFilter.Node(HeroType.Dragon,2,99,"{0}/{1}\t龙免疫魔法伤害",Properties.Resources.Race_dragon),
            new AttrFilter.Node(HeroType.Exile,1,99,"{0}/{1}\t在战斗开始时,如果一名浪人的邻近格子没有友军,那么该浪人会获得一层相当于其100%最大生命值的护盾",Properties.Resources.Race_exile),
            //new AttrFilter.Node(HeroType.Glacial,0,2,"极地生物们的攻击有一定几率造成2秒眩晕效果\t\n{0}/{1}\t",Properties.Resources.Race_glacial),
            new AttrFilter.Node(HeroType.Glacial,2,4,"极地生物们的攻击有一定几率造成2秒眩晕效果\t\n{0}/{1}\t20%几率造成眩晕",Properties.Resources.Race_glacial),
            new AttrFilter.Node(HeroType.Glacial,4,6,"极地生物们的攻击有一定几率造成2秒眩晕效果\t\n{0}/{1}\t30%几率造成眩晕",Properties.Resources.Race_glacial),
            new AttrFilter.Node(HeroType.Glacial,6,99,"极地生物们的攻击有一定几率造成2秒眩晕效果\t\n{0}/{1}\t45%几率造成眩晕",Properties.Resources.Race_glacial),
            //new AttrFilter.Node(HeroType.Imperial,0,2,"帝国单位们造成双倍伤害\t\n{0}/{1}\t",Properties.Resources.Race_imperial),
            new AttrFilter.Node(HeroType.Imperial,2,4,"帝国单位们造成双倍伤害\t\n{0}/{1}\t1名随机帝国单位",Properties.Resources.Race_imperial),
            new AttrFilter.Node(HeroType.Imperial,4,99,"帝国单位们造成双倍伤害\t\n{0}/{1}\t所有帝国单位",Properties.Resources.Race_imperial),
            new AttrFilter.Node(HeroType.Ninja,1,4,"忍者特质只会在你的场上恰好拥有1或4名忍者时激活\t\n{0}/{1}\t忍者+40%攻击伤害",Properties.Resources.Race_ninja),
            new AttrFilter.Node(HeroType.Ninja,4,99,"忍者特质只会在你的场上恰好拥有1或4名忍者时激活\t\n{0}/{1}\t所有忍者+80%攻击伤害",Properties.Resources.Race_ninja),
            //new AttrFilter.Node(HeroType.Noble,0,3,"+100护甲并且每次攻击治疗35生命值\t\n{0}/{1}\t",Properties.Resources.Race_noble),
            new AttrFilter.Node(HeroType.Noble,3,6,"+100护甲并且每次攻击治疗35生命值\t\n{0}/{1}\t1名随机友军",Properties.Resources.Race_noble),
            new AttrFilter.Node(HeroType.Noble,6,99,"+100护甲并且每次攻击治疗35生命值\t\n{0}/{1}\t所有友军",Properties.Resources.Race_noble),
            //new AttrFilter.Node(HeroType.Phantom,0,2,"\t\n{0}/{1}\t暗影",Properties.Resources.Race_phantom),
            new AttrFilter.Node(HeroType.Phantom,2,99,"\t\n{0}/{1}\t在战斗开始时诅咒一名随机的敌人,将其生命值设置为100",Properties.Resources.Race_phantom),
            //new AttrFilter.Node(HeroType.Pirate,0,3,"\t\n{0}/{1}\t海盗",Properties.Resources.Race_pirate),
            new AttrFilter.Node(HeroType.Pirate,3,99,"\t\n{0}/{1}\t在与另一名玩家作战之后,最多可赚取4枚额外的金币",Properties.Resources.Race_pirate),
            new AttrFilter.Node(HeroType.Robot,1,99,"\t\n{0}/{1}\t机器人在开始战斗时就有满额的法力值",Properties.Resources.Race_robot),
            //new AttrFilter.Node(HeroType.Void,0,3,"\t\n{0}/{1}\t虚空",Properties.Resources.Race_void),
            new AttrFilter.Node(HeroType.Void,3,99,"\t\n{0}/{1}\t所有普攻无视敌人50%的护甲",Properties.Resources.Race_void),
            //new AttrFilter.Node(HeroType.Wild,0,2,"攻击会生成怒气层数(最多可叠5层),每层怒气提供8%攻击速度\t\n{0}/{1}\t",Properties.Resources.Race_wild),
            new AttrFilter.Node(HeroType.Wild,2,4,"攻击会生成怒气层数(最多可叠5层),每层怒气提供8%攻击速度\t\n{0}/{1}\t仅限狂野单位友军",Properties.Resources.Race_wild),
            new AttrFilter.Node(HeroType.Wild,4,6,"攻击会生成怒气层数(最多可叠5层),每层怒气提供8%攻击速度\t\n{0}/{1}\t所有友军",Properties.Resources.Race_wild),
            new AttrFilter.Node(HeroType.Wild,6,99,"攻击会生成怒气层数(最多可叠5层),每层怒气提供8%攻击速度\t\n{0}/{1}\t所有友军",Properties.Resources.Race_wild),
            //new AttrFilter.Node(HeroType.Yordle,0,2,"对友方约德尔人仅限的攻击会有一定几率未命中\t\n{0}/{1}\t",Properties.Resources.Race_yordle),
            new AttrFilter.Node(HeroType.Yordle,3,6,"对友方约德尔人仅限的攻击会有一定几率未命中\t\n{0}/{1}\t20%几率造成未命中",Properties.Resources.Race_yordle),
            new AttrFilter.Node(HeroType.Yordle,6,99,"对友方约德尔人仅限的攻击会有一定几率未命中\t\n{0}/{1}\t50几率造成未命中",Properties.Resources.Race_yordle)
        };

        public static Hashtable TABLE = new Hashtable();
        public static Hashtable Hero_Table = new Hashtable();
        public static Hashtable Type_Name = new Hashtable();

        static Global()
        {
            TABLE.Add("Aatrox", "Litle_Util.AatroxHero");
            TABLE.Add("Ahri", "Litle_Util.AhriHero");
            TABLE.Add("Akali", "Litle_Util.AkaliHero");
            TABLE.Add("Anivia", "Litle_Util.AniviaHero");
            TABLE.Add("Ashe", "Litle_Util.AsheHero");
            TABLE.Add("AurelionSol", "Litle_Util.AurelionSolHero");
            TABLE.Add("Blitzcrank", "Litle_Util.BlitzcrankHero");
            TABLE.Add("Brand", "Litle_Util.BrandHero");
            TABLE.Add("Braum", "Litle_Util.BraumHero");
            TABLE.Add("ChoGath", "Litle_Util.ChoGathHero");
            TABLE.Add("Darius", "Litle_Util.DariusHero");
            TABLE.Add("Draven", "Litle_Util.DravenHero");
            TABLE.Add("Elise", "Litle_Util.EliseHero");
            TABLE.Add("Evelynn", "Litle_Util.EvelynnHero");
            TABLE.Add("Fiora", "Litle_Util.FioraHero");
            TABLE.Add("Gangplank", "Litle_Util.GangplankHero");
            TABLE.Add("Garen", "Litle_Util.GarenHero");
            TABLE.Add("Gnar", "Litle_Util.GnarHero");
            TABLE.Add("Graves", "Litle_Util.GravesHero");
            TABLE.Add("Karthus", "Litle_Util.KarthusHero");
            TABLE.Add("Kassadin", "Litle_Util.KassadinHero");
            TABLE.Add("Katarina", "Litle_Util.KatarinaHero");
            TABLE.Add("Kayle", "Litle_Util.KayleHero");
            TABLE.Add("Kennen", "Litle_Util.KennenHero");
            TABLE.Add("KhaZix", "Litle_Util.KhaZixHero");
            TABLE.Add("Kindred", "Litle_Util.KindredHero");
            TABLE.Add("Leona", "Litle_Util.LeonaHero");
            TABLE.Add("Lissandra", "Litle_Util.LissandraHero");
            TABLE.Add("Lucian", "Litle_Util.LucianHero");
            TABLE.Add("Lulu", "Litle_Util.LuluHero");
            TABLE.Add("MissFortune", "Litle_Util.MissFortuneHero");
            TABLE.Add("Mordekaiser", "Litle_Util.MordekaiserHero");
            TABLE.Add("Morgana", "Litle_Util.MorganaHero");
            TABLE.Add("Nidalee", "Litle_Util.NidaleeHero");
            TABLE.Add("Poppy", "Litle_Util.PoppyHero");
            TABLE.Add("Pyke", "Litle_Util.PykeHero");
            TABLE.Add("RekSai", "Litle_Util.RekSaiHero");
            TABLE.Add("Rengar", "Litle_Util.RengarHero");
            TABLE.Add("Sejuani", "Litle_Util.SejuaniHero");
            TABLE.Add("Shen", "Litle_Util.ShenHero");
            TABLE.Add("Shyvana", "Litle_Util.ShyvanaHero");
            TABLE.Add("Swain", "Litle_Util.SwainHero");
            TABLE.Add("Teemo", "Litle_Util.TeemoHero");
            TABLE.Add("Tristana", "Litle_Util.TristanaHero");
            TABLE.Add("TwistedFate", "Litle_Util.TwistedFateHero");
            TABLE.Add("Varus", "Litle_Util.VarusHero");
            TABLE.Add("Vayne", "Litle_Util.VayneHero");
            TABLE.Add("Veigar", "Litle_Util.VeigarHero");
            TABLE.Add("Volibear", "Litle_Util.VolibearHero");
            TABLE.Add("Warwick", "Litle_Util.WarwickHero");
            TABLE.Add("Yasuo", "Litle_Util.YasuoHero");
            TABLE.Add("Zed", "Litle_Util.ZedHero");

            Hero_Table.Add("assassin",HeroType.Assassin);
            Hero_Table.Add("blademaster", HeroType.Blademaster);
            Hero_Table.Add("brawler", HeroType.Brawler);
            Hero_Table.Add("elementalist", HeroType.Elementalist);
            Hero_Table.Add("guardian", HeroType.Guardian);
            Hero_Table.Add("gunslinger", HeroType.Gunslinger);
            Hero_Table.Add("knight", HeroType.Knight);
            Hero_Table.Add("ranger", HeroType.Ranger);
            Hero_Table.Add("shapeshifter", HeroType.Shapeshifter);
            Hero_Table.Add("sorcerer", HeroType.Sorcerer);
            Hero_Table.Add("demon", HeroType.Demon);
            Hero_Table.Add("dragon", HeroType.Dragon);
            Hero_Table.Add("exile", HeroType.Exile);
            Hero_Table.Add("glacial", HeroType.Glacial);
            Hero_Table.Add("imperial", HeroType.Imperial);
            Hero_Table.Add("ninja", HeroType.Ninja);
            Hero_Table.Add("noble", HeroType.Noble);
            Hero_Table.Add("phantom", HeroType.Phantom);
            Hero_Table.Add("pirate", HeroType.Pirate);
            Hero_Table.Add("robot", HeroType.Robot);
            Hero_Table.Add("void", HeroType.Void);
            Hero_Table.Add("wild", HeroType.Wild);
            Hero_Table.Add("yordle", HeroType.Yordle);

            Type_Name.Add(HeroType.Assassin,"刺客");
            Type_Name.Add(HeroType.Blademaster,"剑士");
            Type_Name.Add(HeroType.Brawler,"斗士");
            Type_Name.Add(HeroType.Elementalist,"元素");
            Type_Name.Add(HeroType.Guardian,"护卫");
            Type_Name.Add(HeroType.Gunslinger,"枪手");
            Type_Name.Add(HeroType.Knight,"骑士");
            Type_Name.Add(HeroType.Ranger,"游侠");
            Type_Name.Add(HeroType.Shapeshifter,"换形师");
            Type_Name.Add(HeroType.Sorcerer,"法师");
            Type_Name.Add(HeroType.Demon,"恶魔");
            Type_Name.Add(HeroType.Dragon,"龙");
            Type_Name.Add(HeroType.Exile,"浪人");
            Type_Name.Add(HeroType.Glacial,"极地");
            Type_Name.Add(HeroType.Imperial,"帝国");
            Type_Name.Add(HeroType.Ninja,"忍者");
            Type_Name.Add(HeroType.Noble,"贵族");
            Type_Name.Add(HeroType.Phantom,"暗影");
            Type_Name.Add(HeroType.Pirate,"海盗");
            Type_Name.Add(HeroType.Robot,"机器人");
            Type_Name.Add(HeroType.Void,"虚空");
            Type_Name.Add(HeroType.Wild,"狂野");
            Type_Name.Add(HeroType.Yordle,"约德尔");
        }

        public static bool compute1(HashSet<String> srcSet, HashSet<String> tarSet)
        {
            if (tarSet.Count == 0)
            {
                return false;
            }
            int flag = tarSet.Count / 3;
            int result = 0;

            foreach (String tar in tarSet)
            {
                if (!srcSet.Contains(tar))
                {
                    result++;
                }
            }

            if (result > flag)
            {
                return false;
            }

            return true;
        }
    }
}

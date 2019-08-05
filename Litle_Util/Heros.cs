namespace Litle_Util
{
    public class AatroxHero : Hero
    {
        public AatroxHero()
        {
            this.Code = "Aatrox";   //剑魔
            this.Image = Properties.Resources.Hero_Aatrox_Icon;
            this.TypeCodes.Add(HeroType.Demon);
            this.TypeCodes.Add(HeroType.Blademaster);
            this.Cost = 3;
            this.RecEqus.Add(Properties.Resources.yuumi);
            this.RecEqus.Add(Properties.Resources.Hextech_Gunblade);
            this.RecEqus.Add(Properties.Resources.Spear_Of_Shojin);
        }
    }

    public class AhriHero : Hero
    {
        public AhriHero()
        {
            this.Code = "Ahri";     //狐狸
            this.Image = Properties.Resources.Hero_Ahri_Icon;
            this.TypeCodes.Add(HeroType.Wild);
            this.TypeCodes.Add(HeroType.Sorcerer);
            this.Cost = 2;
        }
    }

    public class AkaliHero : Hero
    {
        public AkaliHero()
        {
            this.Code = "Akali";    //阿卡丽
            this.Image = Properties.Resources.Hero_Akali_Icon;
            this.TypeCodes.Add(HeroType.Ninja);
            this.TypeCodes.Add(HeroType.Sorcerer);
            this.Cost = 5;
        }
    }
    public class AniviaHero : Hero
    {
        public AniviaHero()
        {
            this.Code = "Anivia";   //凤凰
            this.Image = Properties.Resources.Hero_Anivia_Icon;
            this.TypeCodes.Add(HeroType.Elementalist);
            this.TypeCodes.Add(HeroType.Glacial);
            this.Cost = 4;
        }
    }
    public class AsheHero : Hero
    {
        public AsheHero()
        {
            this.Code = "Ashe";     //寒冰
            this.Image = Properties.Resources.Hero_Ashe_Icon;
            this.TypeCodes.Add(HeroType.Glacial);
            this.TypeCodes.Add(HeroType.Ranger);
            this.Cost = 3;
            this.RecEqus.Add(Properties.Resources.Spear_Of_Shojin);
            this.RecEqus.Add(Properties.Resources.Spear_Of_Shojin);
            this.RecEqus.Add(Properties.Resources.rapid_firecannon);
        }
    }
    public class AurelionSolHero : Hero
    {
        public AurelionSolHero()
        {
            this.Code = "AurelionSol";  //龙王
            this.Image = Properties.Resources.Hero_AurelionSol_Icon;
            this.TypeCodes.Add(HeroType.Dragon);
            this.TypeCodes.Add(HeroType.Sorcerer);
            this.Cost = 4;
            this.RecEqus.Add(Properties.Resources.Spear_Of_Shojin);
            this.RecEqus.Add(Properties.Resources.guinsoos_rageblade);
            this.RecEqus.Add(Properties.Resources.rabadons_deathcap);
        }
    }
    public class BlitzcrankHero : Hero
    {
        public BlitzcrankHero()
        {
            this.Code = "Blitzcrank";   //机器人
            this.Image = Properties.Resources.Hero_Blitzcrank_Icon;
            this.TypeCodes.Add(HeroType.Robot);
            this.TypeCodes.Add(HeroType.Brawler);
            this.Cost = 2;
        }
    }
    public class BrandHero : Hero
    {
        public BrandHero()
        {
            this.Code = "Brand";    //火男
            this.Image = Properties.Resources.Hero_Brand_Icon;
            this.TypeCodes.Add(HeroType.Demon);
            this.TypeCodes.Add(HeroType.Elementalist);
            this.Cost = 2;
        }
    }
    public class BraumHero : Hero
    {
        public BraumHero()
        {
            this.Code = "Braum";    //布隆
            this.Image = Properties.Resources.Hero_Braum_Icon;
            this.TypeCodes.Add(HeroType.Glacial);
            this.TypeCodes.Add(HeroType.Guardian);
            this.Cost = 2;
            this.RecEqus.Add(Properties.Resources.thornmail);
            this.RecEqus.Add(Properties.Resources.thornmail);
            this.RecEqus.Add(Properties.Resources.warmogs_armor);
        }
    }
    public class ChoGathHero : Hero
    {
        public ChoGathHero()
        {
            this.Code = "ChoGath";  //大虫子
            this.Image = Properties.Resources.Hero_ChoGath_Icon;
            this.TypeCodes.Add(HeroType.Void);
            this.TypeCodes.Add(HeroType.Brawler);
            this.Cost = 4;
        }
    }
    public class DariusHero : Hero
    {
        public DariusHero()
        {
            this.Code = "Darius";   //诺手
            this.Image = Properties.Resources.Hero_Darius_Icon;
            this.TypeCodes.Add(HeroType.Imperial);
            this.TypeCodes.Add(HeroType.Knight);
            this.Cost = 1;
        }
    }
    public class DravenHero : Hero
    {
        public DravenHero()
        {
            this.Code = "Draven";   //德莱文
            this.Image = Properties.Resources.Hero_Draven_Icon;
            this.TypeCodes.Add(HeroType.Imperial);
            this.TypeCodes.Add(HeroType.Blademaster);
            this.Cost = 5;
        }
    }
    public class EliseHero : Hero
    {
        public EliseHero()
        {
            this.Code = "Elise";   //蜘蛛
            this.Image = Properties.Resources.Hero_Elise_Icon;
            this.TypeCodes.Add(HeroType.Demon);
            this.TypeCodes.Add(HeroType.Shapeshifter);
            this.Cost = 2;
        }
    }
    public class EvelynnHero : Hero
    {
        public EvelynnHero()
        {
            this.Code = "Evelynn";   //寡妇
            this.Image = Properties.Resources.Hero_Evelynn_Icon;
            this.TypeCodes.Add(HeroType.Demon);
            this.TypeCodes.Add(HeroType.Assassin);
            this.Cost = 3;
        }
    }
    public class FioraHero : Hero
    {
        public FioraHero()
        {
            this.Code = "Fiora";   //剑姬
            this.Image = Properties.Resources.Hero_Fiora_Icon;
            this.TypeCodes.Add(HeroType.Noble);
            this.TypeCodes.Add(HeroType.Blademaster);
            this.Cost = 1;
        }
    }
    public class GangplankHero : Hero
    {
        public GangplankHero()
        {
            this.Code = "Gangplank";   //船长
            this.Image = Properties.Resources.Hero_Gangplank_Icon;
            this.TypeCodes.Add(HeroType.Pirate);
            this.TypeCodes.Add(HeroType.Blademaster);
            this.TypeCodes.Add(HeroType.Gunslinger);
            this.Cost = 3;
        }
    }
    public class GarenHero : Hero
    {
        public GarenHero()
        {
            this.Code = "Garen";   //盖伦
            this.Image = Properties.Resources.Hero_Garen_Icon;
            this.TypeCodes.Add(HeroType.Noble);
            this.TypeCodes.Add(HeroType.Knight);
            this.Cost = 1;
        }
    }
    public class GnarHero : Hero
    {
        public GnarHero()
        {
            this.Code = "Gnar";   //纳尔
            this.Image = Properties.Resources.Hero_Gnar_Icon;
            this.TypeCodes.Add(HeroType.Wild);
            this.TypeCodes.Add(HeroType.Shapeshifter);
            this.TypeCodes.Add(HeroType.Yordle);
            this.Cost = 3;
            this.RecEqus.Add(Properties.Resources.titanic_hydra);
            this.RecEqus.Add(Properties.Resources.dragons_claw);
            this.RecEqus.Add(Properties.Resources.phantom_dancer);
        }
    }
    public class GravesHero : Hero
    {
        public GravesHero()
        {
            this.Code = "Graves";   //男枪
            this.Image = Properties.Resources.Hero_Graves_Icon;
            this.TypeCodes.Add(HeroType.Pirate);
            this.TypeCodes.Add(HeroType.Gunslinger);
            this.Cost = 2;
            this.RecEqus.Add(Properties.Resources.sword_breaker);
            this.RecEqus.Add(Properties.Resources.red_buff);
            this.RecEqus.Add(Properties.Resources.titanic_hydra);
        }
    }
    public class KarthusHero : Hero
    {
        public KarthusHero()
        {
            this.Code = "Karthus";   //死歌
            this.Image = Properties.Resources.Hero_Karthus_Icon;
            this.TypeCodes.Add(HeroType.Demon);
            this.TypeCodes.Add(HeroType.Sorcerer);
            this.Cost = 4;
        }
    }
    public class KassadinHero : Hero
    {
        public KassadinHero()
        {
            this.Code = "Kassadin";   //卡萨丁
            this.Image = Properties.Resources.Hero_Kassadin_Icon;
            this.TypeCodes.Add(HeroType.Void);
            this.TypeCodes.Add(HeroType.Sorcerer);
            this.Cost = 1;
        }
    }
    public class KatarinaHero : Hero
    {
        public KatarinaHero()
        {
            this.Code = "Katarina";   //卡特
            this.Image = Properties.Resources.Hero_Katarina_Icon;
            this.TypeCodes.Add(HeroType.Imperial);
            this.TypeCodes.Add(HeroType.Assassin);
            this.Cost = 3;
        }
    }
    public class KayleHero : Hero
    {
        public KayleHero()
        {
            this.Code = "Kayle";   //天使
            this.Image = Properties.Resources.Hero_Kayle_Icon;
            this.TypeCodes.Add(HeroType.Noble);
            this.TypeCodes.Add(HeroType.Knight);
            this.Cost = 5;
        }
    }
    public class KennenHero : Hero
    {
        public KennenHero()
        {
            this.Code = "Kennen";   //凯南
            this.Image = Properties.Resources.Hero_Kennen_Icon;
            this.TypeCodes.Add(HeroType.Ninja);
            this.TypeCodes.Add(HeroType.Elementalist);
            this.TypeCodes.Add(HeroType.Yordle);
            this.Cost = 2;
        }
    }
    public class KhaZixHero : Hero
    {
        public KhaZixHero()
        {
            this.Code = "KhaZix";   //螳螂
            this.Image = Properties.Resources.Hero_KhaZix_Icon;
            this.TypeCodes.Add(HeroType.Void);
            this.TypeCodes.Add(HeroType.Assassin);
            this.Cost = 1;
        }
    }
    public class KindredHero : Hero
    {
        public KindredHero()
        {
            this.Code = "Kindred";   //千蕨
            this.Image = Properties.Resources.Hero_Kindred_Icon;
            this.TypeCodes.Add(HeroType.Phantom);
            this.TypeCodes.Add(HeroType.Ranger);
            this.Cost = 4;
        }
    }
    public class LeonaHero : Hero
    {
        public LeonaHero()
        {
            this.Code = "Leona";   //曙光
            this.Image = Properties.Resources.Hero_Leona_Icon;
            this.TypeCodes.Add(HeroType.Noble);
            this.TypeCodes.Add(HeroType.Guardian);
            this.Cost = 4;
        }
    }
    public class LissandraHero : Hero
    {
        public LissandraHero()
        {
            this.Code = "Lissandra";   //女巫
            this.Image = Properties.Resources.Hero_Lissandra_Icon;
            this.TypeCodes.Add(HeroType.Glacial);
            this.TypeCodes.Add(HeroType.Elementalist);
            this.Cost = 2;
        }
    }
    public class LucianHero : Hero
    {
        public LucianHero()
        {
            this.Code = "Lucian";   //卢锡安
            this.Image = Properties.Resources.Hero_Lucian_Icon;
            this.TypeCodes.Add(HeroType.Noble);
            this.TypeCodes.Add(HeroType.Gunslinger);
            this.Cost = 2;
            this.RecEqus.Add(Properties.Resources.rabadons_deathcap);
            this.RecEqus.Add(Properties.Resources.rabadons_deathcap);
            this.RecEqus.Add(Properties.Resources.ludens_echo);
        }
    }
    public class LuluHero : Hero
    {
        public LuluHero()
        {
            this.Code = "Lulu";   //露露
            this.Image = Properties.Resources.Hero_Lulu_Icon;
            this.TypeCodes.Add(HeroType.Sorcerer);
            this.TypeCodes.Add(HeroType.Yordle);
            this.Cost = 1;
        }
    }
    public class MissFortuneHero : Hero
    {
        public MissFortuneHero()
        {
            this.Code = "MissFortune";   //赏金
            this.Image = Properties.Resources.Hero_MissFortune_Icon;
            this.TypeCodes.Add(HeroType.Pirate);
            this.TypeCodes.Add(HeroType.Gunslinger);
            this.Cost = 5;
        }
    }
    public class MordekaiserHero : Hero
    {
        public MordekaiserHero()
        {
            this.Code = "Mordekaiser";   //暗影之主
            this.Image = Properties.Resources.Hero_Mordekaiser_Icon;
            this.TypeCodes.Add(HeroType.Phantom);
            this.TypeCodes.Add(HeroType.Knight);
            this.Cost = 2;
        }
    }
    public class MorganaHero : Hero
    {
        public MorganaHero()
        {
            this.Code = "Morgana";   //莫甘娜
            this.Image = Properties.Resources.Hero_Morgana_Icon;
            this.TypeCodes.Add(HeroType.Demon);
            this.TypeCodes.Add(HeroType.Sorcerer);
            this.Cost = 3;
        }
    }
    public class NidaleeHero : Hero
    {
        public NidaleeHero()
        {
            this.Code = "Nidalee";   //豹女
            this.Image = Properties.Resources.Hero_Nidalee_Icon;
            this.TypeCodes.Add(HeroType.Wild);
            this.TypeCodes.Add(HeroType.Shapeshifter);
            this.Cost = 1;
        }
    }
    public class PoppyHero : Hero
    {
        public PoppyHero()
        {
            this.Code = "Poppy";   //波比
            this.Image = Properties.Resources.Hero_Poppy_Icon;
            this.TypeCodes.Add(HeroType.Knight);
            this.TypeCodes.Add(HeroType.Yordle);
            this.Cost = 3;
        }
    }
    public class PykeHero : Hero
    {
        public PykeHero()
        {
            this.Code = "Pyke";   //派克
            this.Image = Properties.Resources.Hero_Pyke_Icon;
            this.TypeCodes.Add(HeroType.Pirate);
            this.TypeCodes.Add(HeroType.Assassin);
            this.Cost = 2;
        }
    }
    public class RekSaiHero : Hero
    {
        public RekSaiHero()
        {
            this.Code = "RekSai";   //雷克塞
            this.Image = Properties.Resources.Hero_RekSai_Icon;
            this.TypeCodes.Add(HeroType.Void);
            this.TypeCodes.Add(HeroType.Brawler);
            this.Cost = 2;
        }
    }
    public class RengarHero : Hero
    {
        public RengarHero()
        {
            this.Code = "Rengar";   //狮子狗
            this.Image = Properties.Resources.Hero_Rengar_Icon;
            this.TypeCodes.Add(HeroType.Wild);
            this.TypeCodes.Add(HeroType.Assassin);
            this.Cost = 3;
        }
    }
    public class SejuaniHero : Hero
    {
        public SejuaniHero()
        {
            this.Code = "Sejuani";   //猪妹
            this.Image = Properties.Resources.Hero_Sejuani_Icon;
            this.TypeCodes.Add(HeroType.Glacial);
            this.TypeCodes.Add(HeroType.Knight);
            this.Cost = 4;
        }
    }
    public class ShenHero : Hero
    {
        public ShenHero()
        {
            this.Code = "Shen";   //慎
            this.Image = Properties.Resources.Hero_Shen_Icon;
            this.TypeCodes.Add(HeroType.Ninja);
            this.TypeCodes.Add(HeroType.Blademaster);
            this.Cost = 2;
        }
    }
    public class ShyvanaHero : Hero
    {
        public ShyvanaHero()
        {
            this.Code = "Shyvana";   //龙女
            this.Image = Properties.Resources.Hero_Shyvana_Icon;
            this.TypeCodes.Add(HeroType.Dragon);
            this.TypeCodes.Add(HeroType.Shapeshifter);
            this.Cost = 3;
            this.RecEqus.Add(Properties.Resources.thornmail);
            this.RecEqus.Add(Properties.Resources.phantom_dancer);
            this.RecEqus.Add(Properties.Resources.warmogs_armor);
        }
    }
    public class SwainHero : Hero
    {
        public SwainHero()
        {
            this.Code = "Swain";   //乌鸦
            this.Image = Properties.Resources.Hero_Swain_Icon;
            this.TypeCodes.Add(HeroType.Demon);
            this.TypeCodes.Add(HeroType.Imperial);
            this.TypeCodes.Add(HeroType.Shapeshifter);
            this.Cost = 4;
        }
    }
    public class TeemoHero : Hero
    {
        public TeemoHero()
        {
            this.Code = "Teemo";   //提莫
            this.Image = Properties.Resources.Hero_Teemo_Icon;
            this.Cost = 0;
        }
    }
    public class TristanaHero : Hero
    {
        public TristanaHero()
        {
            this.Code = "Tristana";   //小炮
            this.Image = Properties.Resources.Hero_Tristana_Icon;
            this.TypeCodes.Add(HeroType.Yordle);
            this.TypeCodes.Add(HeroType.Gunslinger);
            this.Cost = 1;
        }
    }
    public class TwistedFateHero : Hero
    {
        public TwistedFateHero()
        {
            this.Code = "TwistedFate";   //卡牌
            this.Image = Properties.Resources.Hero_TwistedFate_Icon;
            this.TypeCodes.Add(HeroType.Pirate);
            this.TypeCodes.Add(HeroType.Sorcerer);
            this.Cost = 1;
        }
    }
    public class VarusHero : Hero
    {
        public VarusHero()
        {
            this.Code = "Varus";   //韦鲁思
            this.Image = Properties.Resources.Hero_Varus_Icon;
            this.TypeCodes.Add(HeroType.Demon);
            this.TypeCodes.Add(HeroType.Ranger);
            this.Cost = 2;
        }
    }
    public class VayneHero : Hero
    {
        public VayneHero()
        {
            this.Code = "Vayne";   //薇恩
            this.Image = Properties.Resources.Hero_Vayne_Icon;
            this.TypeCodes.Add(HeroType.Noble);
            this.TypeCodes.Add(HeroType.Ranger);
            this.Cost = 1;
            this.RecEqus.Add(Properties.Resources.guinsoos_rageblade);
            this.RecEqus.Add(Properties.Resources.guinsoos_rageblade);
            this.RecEqus.Add(Properties.Resources.rapid_firecannon);
        }
    }
    public class VeigarHero : Hero
    {
        public VeigarHero()
        {
            this.Code = "Veigar";   //小法
            this.Image = Properties.Resources.Hero_Veigar_Icon;
            this.TypeCodes.Add(HeroType.Yordle);
            this.TypeCodes.Add(HeroType.Sorcerer);
            this.Cost = 1;
        }
    }
    public class VolibearHero : Hero
    {
        public VolibearHero()
        {
            this.Code = "Volibear";   //狗熊
            this.Image = Properties.Resources.Hero_Volibear_Icon;
            this.TypeCodes.Add(HeroType.Glacial);
            this.TypeCodes.Add(HeroType.Brawler);
            this.Cost = 3;
        }
    }
    public class WarwickHero : Hero
    {
        public WarwickHero()
        {
            this.Code = "Warwick";   //狼人
            this.Image = Properties.Resources.Hero_Warwick_Icon;
            this.TypeCodes.Add(HeroType.Wild);
            this.TypeCodes.Add(HeroType.Brawler);
            this.Cost = 1;
        }
    }
    public class YasuoHero : Hero
    {
        public YasuoHero()
        {
            this.Code = "Yasuo";   //亚索
            this.Image = Properties.Resources.Hero_Yasuo_Icon;
            this.TypeCodes.Add(HeroType.Exile);
            this.TypeCodes.Add(HeroType.Blademaster);
            this.Cost = 5;
            this.RecEqus.Add(Properties.Resources.statikk_shiv);
            this.RecEqus.Add(Properties.Resources.Sword_Of_The_Divine);
            this.RecEqus.Add(Properties.Resources.dragons_claw);
        }
    }
    public class ZedHero : Hero
    {
        public ZedHero()
        {
            this.Code = "Zed";   //劫
            this.Image = Properties.Resources.Hero_Zed_Icon;
            this.TypeCodes.Add(HeroType.Ninja);
            this.TypeCodes.Add(HeroType.Assassin);
            this.Cost = 2;
        }
    }
}

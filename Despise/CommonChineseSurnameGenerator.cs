namespace Despise
{
    public class CommonChineseSurnameGenerator : GeneratorBase<char>
    {
        private const string COMMON_CHINESE_SURNAME_SET = "李王张刘陈杨赵黄周吴徐孙胡朱高林何郭马罗梁宋郑谢韩唐冯于董萧程曹袁邓许傅沈曾彭吕苏卢蒋蔡贾丁魏薛叶阎余潘杜戴夏锺汪田任姜范方石姚谭廖邹熊金陆郝孔白崔康毛邱秦江史顾侯邵孟龙万段雷钱汤尹黎易常武乔贺赖龚文庞樊兰殷施陶洪翟安颜倪严牛温芦季俞章鲁葛伍韦申尤毕聂丛焦向柳邢路岳齐沿梅莫庄辛管祝左涂谷祁时舒耿牟卜路詹关苗凌费纪靳盛童欧甄项曲成游阳裴席卫查屈鲍位覃霍翁隋植甘景薄单包司柏宁柯阮桂闵解强柴华车冉房边辜吉饶刁瞿戚丘古米池滕晋苑邬臧畅宫来嵺苟全褚廉简娄盖符奚木穆党燕郎邸冀谈姬屠连郜晏栾郁商蒙计喻揭窦迟宇敖糜鄢冷卓花仇艾蓝都巩稽井练仲乐虞卞封竺冼原官衣楚佟栗匡宗应台巫鞠僧桑荆谌银扬明沙薄伏岑习胥保和蔺";
        public override char Generate()
        {
            return COMMON_CHINESE_SURNAME_SET[Random.Next(0, COMMON_CHINESE_SURNAME_SET.Length)];
        }
    }
}
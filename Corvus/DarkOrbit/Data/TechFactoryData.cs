using System;
using Corvus.EnumExtension.Attribute;

namespace Corvus.DarkOrbit.Data
{
    public class TechFactoryData
    {
        public enum TechFactoryItem
        {
            [FullName("")]
            [ShortName("")]
            None = 0,
            [FullName("Energy Leech")]
            [ShortName("ELA")]
            EnergyLeech,
            [FullName("Chain Impulse")]
            [ShortName("ECI")]
            ChainImpulse,
            [FullName("Precision Targeter")]
            [ShortName("RPM")]
            PrecisionTargeter,
            [FullName("Backup Shields")]
            [ShortName("SBU")]
            BackupShields,
            [FullName("Battle Repair Bot")]
            [ShortName("BRB")]
            BattleRepairBot
        }
        public class HallInfo
        {
            public bool Enabled { get; set; }

            public bool Building { get; set; }

            public TimeSpan TimeLeft { get; set; }

            public TechFactoryItem Item { get; set; }

            public int Amount { get; set; }

            public HallInfo()
            {
                TimeLeft = TimeSpan.Zero;
            }
        }

        public HallInfo Hall1 { get; set; }
        public HallInfo Hall2 { get; set; }
        public HallInfo Hall3 { get; set; }

        public HallInfo GetById(int i)
        {
            switch (i)
            {
                case 1:
                    return Hall1;
                case 2:
                    return Hall2;
                case 3:
                    return Hall3;
                default:
                    return null;
            }
        }

        public TechFactoryData()
        {
            Hall1 = new HallInfo();
            Hall2 = new HallInfo();
            Hall3 = new HallInfo();
        }
    }
}

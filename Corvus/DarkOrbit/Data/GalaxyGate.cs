using System.Collections.Generic;
using System.Xml.Serialization;
using Corvus.EnumExtension;
using Corvus.EnumExtension.Attribute;

namespace Corvus.DarkOrbit.Data
{
    public enum GalaxyGate
    {
        [FullName("None")]
        None = 0,
        [FullName("Alpha")]
        Alpha = 1,
        [FullName("Beta")]
        Beta = 2,
        [FullName("Gamma")]
        Gamma = 3,
        [FullName("Delta")]
        Delta = 4,
        [FullName("Epsilon")]
        Epsilon = 5,
        [FullName("Zeta")]
        Zeta =  6,
        [FullName("Kappa")]
        Kappa = 7,
        [FullName("Lambda")]
        Lambda = 8,
        [FullName("Hades")]
        Hades = 13,
        [FullName("Streuner")]
        Kuiper = 19
    }


    [XmlRoot(ElementName = "multiplier")]
    public class Multiplier
    {
        [XmlAttribute(AttributeName = "mode")]
        public string Mode { get; set; }
        [XmlAttribute(AttributeName = "value")]
        public int Value { get; set; }
        [XmlAttribute(AttributeName = "state")]
        public int State { get; set; }
    }
    [XmlRoot(ElementName = "multipliers")]
    public class Multipliers
    {
        [XmlElement(ElementName = "multiplier")]
        public List<Multiplier> MultiplierInfo { get; set; }
    }

    [XmlRoot(ElementName = "jumpgate")]
    public class GateData
    {
        [XmlElement(ElementName = "mode")]
        public string Mode { get; set; }
        [XmlElement(ElementName = "money")]
        public int Money { get; set; }
        [XmlElement(ElementName = "samples")]
        public int Samples { get; set; }
        [XmlElement(ElementName = "energy_cost")]
        public EnergyCostInfo EnergyCost { get; set; }
        [XmlElement(ElementName = "multipliers")]
        public Multipliers MultiplierInfo { get; set; }
        [XmlElement(ElementName = "gates")]
        public GatesInfo Gates { get; set; }

        [XmlRoot(ElementName = "energy_cost")]
        public class EnergyCostInfo
        {
            [XmlAttribute(AttributeName = "mode")]
            public string Mode { get; set; }
            [XmlText]
            public int Text { get; set; }
        }

     

        [XmlRoot(ElementName = "gate")]
        public class Gate
        {
            public bool Ready => Current == Total;

            [XmlAttribute(AttributeName = "total")]
            public int Total { get; set; }
            [XmlAttribute(AttributeName = "current")]
            public int Current { get; set; }
            [XmlAttribute(AttributeName = "id")]
            public int Id { get; set; }
            [XmlAttribute(AttributeName = "prepared")]
            public bool Prepared { get; set; }
            [XmlAttribute(AttributeName = "totalWave")]
            public int TotalWave { get; set; }
            [XmlAttribute(AttributeName = "currentWave")]
            public int CurrentWave { get; set; }
            [XmlAttribute(AttributeName = "state")]
            public string State { get; set; }
            [XmlAttribute(AttributeName = "livesLeft")]
            public int LivesLeft { get; set; }
            [XmlAttribute(AttributeName = "lifePrice")]
            public int LifePrice { get; set; }
        }


        [XmlRoot(ElementName = "gates")]
        public class GatesInfo
        {
            [XmlElement(ElementName = "gate")]
            public List<Gate> Gates { get; set; }

            public Gate Get(GalaxyGate gate)
            {
                return Gates.Find(x => x.Id == (int)gate);
            }

            public Gate Alpha()
            {
                return Gates.Find(x => x.Id == (int)GalaxyGate.Alpha);
            }

            public Gate Beta()
            {
                return Gates.Find(x => x.Id == (int)GalaxyGate.Beta);
            }

            public Gate Gamma()
            {
                return Gates.Find(x => x.Id == (int)GalaxyGate.Gamma);
            }

            public Gate Delta()
            {
                return Gates.Find(x => x.Id == (int)GalaxyGate.Delta);
            }

            public Gate Epsilon()
            {
                return Gates.Find(x => x.Id == (int)GalaxyGate.Epsilon);
            }

            public Gate Zeta()
            {
                return Gates.Find(x => x.Id == (int)GalaxyGate.Zeta);
            }

            public Gate Kappa()
            {
                return Gates.Find(x => x.Id == (int)GalaxyGate.Kappa);
            }

            public Gate Lambda()
            {
                return Gates.Find(x => x.Id == (int)GalaxyGate.Lambda);
            }

            public Gate Kuiper()
            {
                return Gates.Find(x => x.Id == (int)GalaxyGate.Kuiper);
            }

            public Gate Hades()
            {
                return Gates.Find(x => x.Id == (int)GalaxyGate.Hades);
            }
        }
    }

    [XmlRoot(ElementName = "jumpgate", IsNullable = true)]
    public class GateSpinData
    {
        [XmlElement(ElementName = "money")]
        public int Money { get; set; }
        [XmlElement(ElementName = "samples")]
        public int Samples { get; set; }
        [XmlElement(ElementName = "energy_cost")]
        public EnergyCostInfo EnergyCost { get; set; }
        [XmlElement(ElementName = "items")]
        public ItemsInfo Items { get; set; }

        [XmlElement(ElementName = "multipliers")]
        public Multipliers MultiplierInfo { get; set; }

        [XmlRoot(ElementName = "energy_cost")]
        public class EnergyCostInfo
        {
            [XmlAttribute(AttributeName = "mode")]
            public string Mode { get; set; }
            [XmlText]
            public int Text { get; set; }
        }

        [XmlRoot(ElementName = "item")]
        public class Item
        {
            [XmlAttribute(AttributeName = "type")]
            public string Type { get; set; }
            [XmlAttribute(AttributeName = "item_id")]
            public int ItemId { get; set; }
            [XmlAttribute(AttributeName = "amount")]
            public int Amount { get; set; }
            [XmlAttribute(AttributeName = "current")]
            public int Current { get; set; }
            [XmlAttribute(AttributeName = "total")]
            public int Total { get; set; }
            [XmlAttribute(AttributeName = "state")]

            public string State { get; set; }
            [XmlAttribute(AttributeName = "date")]
            public string Date { get; set; }
            [XmlAttribute(AttributeName = "gate_id")]
            public int GateId { get; set; }
            [XmlAttribute(AttributeName = "part_id")]
            public int PartId { get; set; }
            [XmlAttribute(AttributeName = "multiplier_used")]
            public int MultiplierUsed { get; set; }
            [XmlAttribute(AttributeName = "duplicate")]
            public bool Duplicate { get; set; }

            public override string ToString()
            {
                if (Type == "part")
                {
                    return $"{((GalaxyGate)GateId).GetFullName()} part #{PartId} ({Current}/{Total})";
                }

                if (Type == "battery")
                {
                    switch (ItemId)
                    {
                        case 2:
                            return $"X2: {Amount}";
                        case 3:
                            return $"X3: {Amount}";
                        case 4:
                            return $"X4: {Amount}";
                        case 5:
                            return $"SAB: {Amount}";
                    }
                }

                if (Type == "ore" && ItemId == 4)
                {
                    return $"Xenomit: {Amount}";
                }

                if (Type == "rocket")
                {
                    switch (ItemId)
                    {
                        case 3:
                            return $"PLT-2021: {Amount}";
                        case 11:
                            return $"ACM: {Amount}";
                    }
                }

                if (Type == "logfile")
                {
                    return $"Log Disks: {Amount}";
                }

                if (Type == "voucher")
                {
                    return $"Repair credits: {Amount}";
                }

                if (Type == "nanohull")
                {
                    return $"Nano hull: {Amount}";
                }

                return $"{Type}: {Amount}";
            }
        }

        [XmlRoot(ElementName = "items", IsNullable = true)]
        public class ItemsInfo
        {
            [XmlElement(ElementName = "item", IsNullable = true)]
            public List<Item> Items { get; set; }
            public Item Item { get; set; }

            public List<Item> GetAllItems()
            {
                if (Items == null)
                {
                    Items = new List<Item>();
                }

                if (Item != null)
                {
                    Items.Add(Item);
                }
                return Items;
            }
        }
    }

    public class GateItemsReceived
    {
        public int TotalSpins { get; set; }

        public int GateParts { get; set; }

        public int X2 { get; set; }
        public int X3 { get; set; }
        public int X4 { get; set; }
        public int SAB { get; set; }
        public int PLT2021 { get; set; }
        public int ACM { get; set; }

        public int LogDisks { get; set; }
        public int RepairCredits { get; set; }
        public int Xenomit { get; set; }
        public int NanoHull { get; set; }

        public void Reset()
        {
            TotalSpins = 0;
            GateParts = 0;
            X2 = 0;
            X3 = 0;
            X4 = 0;
            SAB = 0;
            PLT2021 = 0;
            ACM = 0;
            LogDisks = 0;
            RepairCredits = 0;
            Xenomit = 0;
            NanoHull = 0;
        }
    }
}

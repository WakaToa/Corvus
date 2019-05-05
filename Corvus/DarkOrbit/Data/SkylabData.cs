using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Corvus.DarkOrbit.Data
{
    public class SkylabData
    {
        public class ModuleInfo
        {
            public bool Upgrading { get; set; }

            public TimeSpan TimeLeft { get; set; }

            public int Level { get; set; }

            public ModuleInfo()
            {
                TimeLeft = TimeSpan.Zero;
            }
        }

        public ModuleInfo BaseModuleInfo { get; set; }
        public ModuleInfo PrometiumCollectorInfo { get; set; }
        public ModuleInfo EnduriumCollectorInfo { get; set; }
        public ModuleInfo TerbiumCollectorInfo { get; set; }
        public ModuleInfo SolarModuleInfo { get; set; }
        public ModuleInfo StorageModuleInfo { get; set; }
        public ModuleInfo PrometidRefineryInfo { get; set; }
        public ModuleInfo DuraniumRefineryInfo { get; set; }
        public ModuleInfo PromeriumRefineryInfo { get; set; }
        public ModuleInfo XenomitModuleInfo { get; set; }
        public ModuleInfo SepromRefineryInfo { get; set; }

        public bool IsSending { get; set; }

        public int PromeriumAmount { get; set; }
        public int SepromAmount { get; set; }

        public SkylabData()
        {
            BaseModuleInfo = new ModuleInfo();
            PrometiumCollectorInfo = new ModuleInfo();
            EnduriumCollectorInfo = new ModuleInfo();
            TerbiumCollectorInfo = new ModuleInfo();
            SolarModuleInfo = new ModuleInfo();
            StorageModuleInfo = new ModuleInfo();
            PrometidRefineryInfo = new ModuleInfo();
            DuraniumRefineryInfo = new ModuleInfo();
            PromeriumRefineryInfo = new ModuleInfo();
            XenomitModuleInfo = new ModuleInfo();
            SepromRefineryInfo = new ModuleInfo();
        }
    }
}

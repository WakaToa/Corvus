using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Corvus.Http
{
    public static class Urls
    {
        public static string Build(string url)
        {
            return string.Format(url, BaseUrl);
        }

        public static string BaseUrl { get; set; }

        public static string LoginPortal { get; set; }

        public static string OpenBackPage { get; } = "{0}/?dosid={1}";

        public static string InternalStart { get; } =  "{0}/indexInternal.es?action=internalStart";

        public static string InternalNanoTechFactory { get;} = "{0}/indexInternal.es?action=internalNanoTechFactory";

        public static string BuildTech { get; } = "{0}/indexInternal.es?action=internalNanoTechFactory&subaction=buildBuff&buff={1}&level=1&reloadToken={2}";

        public static string InternalSkylab { get; } = "{0}/indexInternal.es?action=internalSkylab";

        public static string UpgradeSkylab { get; } = "{0}/indexInternal.es?action=internalSkylab&subaction=upgrade&construction={1}&reloadToken={2}";

        public static string SpinGate { get; } =
            "{0}/flashinput/galaxyGates.php?userID={1}&action=multiEnergy&sid={2}&gateID={3}&{4}=1&multiplier=1";

        public static string SpinGateSample { get; } =
            "{0}/flashinput/galaxyGates.php?userID={1}&action=multiEnergy&sid={2}&gateID={3}&{4}=1&multiplier=1&sample=1";

        public static string GateInfo { get; } =
            "{0}/flashinput/galaxyGates.php?userID={1}&action=init&sid={2}";

        public static string PlaceGate { get; } =
            "{0}/flashinput/galaxyGates.php?userID={1}&sid={2}&action=setupGate&gateID={3}";

    }
}

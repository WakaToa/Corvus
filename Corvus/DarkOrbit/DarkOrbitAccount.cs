using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Serialization;
using Corvus.DarkOrbit.Data;
using Corvus.EnumExtension;
using Corvus.Http;
using Corvus.Time;

namespace Corvus.DarkOrbit
{
    public class DarkOrbitAccount
    {
        public AccountData AccountData { get; set; }

        public SkylabData SkylabData { get; set; }

        public TechFactoryData TechFactoryData { get; set; }

        public GateData GateData { get; set; }

        public GateItemsReceived GateItemsReceived { get; set; }

        private DarkOrbitHttpClient _httpClient;

        public DarkOrbitAccount()
        {
            AccountData = new AccountData();
            SkylabData = new SkylabData();
            TechFactoryData = new TechFactoryData();
            GateItemsReceived = new GateItemsReceived();

            _httpClient = new DarkOrbitHttpClient();
        }

        public DarkOrbitAccount(string server, string sessionId) : this()
        {
            AccountData.Server = server;
            AccountData.SessionId = sessionId;

            Urls.BaseUrl = $"https://{server}.darkorbit.com";

            SetSessionIdCookie();
            _httpClient.LoggedIn = true;
        }

        public DarkOrbitAccount(string username, string password, string portal) : this()
        {
            AccountData.Username = username;
            AccountData.Password = password;

            Urls.LoginPortal = portal;

            AccountData.UsernamePasswordLogin = true;
        }

        public async Task<bool> LoginAsync()
        {
            var homepage = await _httpClient.GetAsyncLimit(Urls.LoginPortal);

            var loginUrl = Regex.Match(homepage, "class=\"bgcdw_login_form\" action=\"(.*?)\">").Groups[1].Value;
            loginUrl = loginUrl.Replace("amp;", "");

            var loggedInRaw = await _httpClient.PostAsyncLimitRaw(loginUrl, $"username={WebUtility.UrlEncode(AccountData.Username)}&password={WebUtility.UrlEncode(AccountData.Password)}");
            var loggedIn = await _httpClient.ReadResponseAsync(loggedInRaw);
            if (!loggedIn.Contains("dosid"))
            {
                return false;
            }

            AccountData.Server = loggedInRaw.RequestMessage.RequestUri.Host.Split('.')[0];
            Urls.BaseUrl = $"https://{AccountData.Server}.darkorbit.com";

            AccountData.UserId = Regex.Match(loggedIn, "\"uid\":(.*?),").Groups[1].Value;
            AccountData.SessionId = Regex.Match(loggedIn, "'dosid=(.*?)'").Groups[1].Value;

            _httpClient.LoggedIn = true;
            return true;
        }

        private void SetSessionIdCookie()
        {
            _httpClient.SetCookie("dosid", AccountData.SessionId, Urls.BaseUrl);
        }

        public async Task<bool> CheckSessionValidAsync()
        {
            var rawResponse = await _httpClient.GetAsyncLimit(Urls.Build(Urls.InternalStart));

            if (rawResponse.Contains("dosid"))
            {
                AccountData.Username = Regex.Match(rawResponse, "alt=\"(.*?)\" id=\"pilotAvatar\"").Groups[1].Value;

                AccountData.UserId = Regex.Match(rawResponse, "\"uid\":(.*?),").Groups[1].Value;

                return true;
            }

            return false;
        }

        public async Task ReadSkylabAsync()
        {
            var skylab = await _httpClient.GetAsyncLimit(Urls.Build(Urls.InternalSkylab));

            var levelsRegex = Regex.Matches(skylab, "<div class=\"level skylab_font_level\">(.*?)</div>");

            try
            {
                SkylabData.BaseModuleInfo.Upgrading = skylab.Contains("timers_baseModule");
                if (SkylabData.BaseModuleInfo.Upgrading)
                {
                    SkylabData.BaseModuleInfo.TimeLeft = GetSkylabTimeLeft(skylab, "baseModule");
                }
                SkylabData.BaseModuleInfo.Level = int.Parse(levelsRegex[0].Groups[1].Value);

                SkylabData.SolarModuleInfo.Upgrading = skylab.Contains("timers_solarModule");
                if (SkylabData.SolarModuleInfo.Upgrading)
                {
                    SkylabData.SolarModuleInfo.TimeLeft = GetSkylabTimeLeft(skylab, "solarModule");
                }
                SkylabData.SolarModuleInfo.Level = int.Parse(levelsRegex[1].Groups[1].Value);

                SkylabData.StorageModuleInfo.Upgrading = skylab.Contains("timers_storageModule");
                if (SkylabData.StorageModuleInfo.Upgrading)
                {
                    SkylabData.StorageModuleInfo.TimeLeft = GetSkylabTimeLeft(skylab, "storageModule");
                }
                SkylabData.StorageModuleInfo.Level = int.Parse(levelsRegex[2].Groups[1].Value);

                SkylabData.XenomitModuleInfo.Upgrading = skylab.Contains("timers_xenoModule");
                if (SkylabData.XenomitModuleInfo.Upgrading)
                {
                    SkylabData.XenomitModuleInfo.TimeLeft = GetSkylabTimeLeft(skylab, "xenoModule");
                }
                SkylabData.XenomitModuleInfo.Level = int.Parse(levelsRegex[4].Groups[1].Value);

                SkylabData.PrometiumCollectorInfo.Upgrading = skylab.Contains("timers_prometiumCollector");
                if (SkylabData.PrometiumCollectorInfo.Upgrading)
                {
                    SkylabData.PrometiumCollectorInfo.TimeLeft = GetSkylabTimeLeft(skylab, "prometiumCollector");
                }
                SkylabData.PrometiumCollectorInfo.Level = int.Parse(levelsRegex[5].Groups[1].Value);

                SkylabData.EnduriumCollectorInfo.Upgrading = skylab.Contains("timers_enduriumCollector");
                if (SkylabData.EnduriumCollectorInfo.Upgrading)
                {
                    SkylabData.EnduriumCollectorInfo.TimeLeft = GetSkylabTimeLeft(skylab, "enduriumCollector");
                }
                SkylabData.EnduriumCollectorInfo.Level = int.Parse(levelsRegex[6].Groups[1].Value);

                SkylabData.TerbiumCollectorInfo.Upgrading = skylab.Contains("timers_terbiumCollector");
                if (SkylabData.TerbiumCollectorInfo.Upgrading)
                {
                    SkylabData.TerbiumCollectorInfo.TimeLeft = GetSkylabTimeLeft(skylab, "terbiumCollector");
                }
                SkylabData.TerbiumCollectorInfo.Level = int.Parse(levelsRegex[7].Groups[1].Value);

                SkylabData.PrometidRefineryInfo.Upgrading = skylab.Contains("timers_prometidRefinery");
                if (SkylabData.PrometidRefineryInfo.Upgrading)
                {
                    SkylabData.PrometidRefineryInfo.TimeLeft = GetSkylabTimeLeft(skylab, "prometidRefinery");
                }
                SkylabData.PrometidRefineryInfo.Level = int.Parse(levelsRegex[8].Groups[1].Value);

                SkylabData.DuraniumRefineryInfo.Upgrading = skylab.Contains("timers_duraniumRefinery");
                if (SkylabData.DuraniumRefineryInfo.Upgrading)
                {
                    SkylabData.DuraniumRefineryInfo.TimeLeft = GetSkylabTimeLeft(skylab, "duraniumRefinery");
                }
                SkylabData.DuraniumRefineryInfo.Level = int.Parse(levelsRegex[9].Groups[1].Value);

                SkylabData.PromeriumRefineryInfo.Upgrading = skylab.Contains("timers_promeriumRefinery");
                if (SkylabData.PromeriumRefineryInfo.Upgrading)
                {
                    SkylabData.PromeriumRefineryInfo.TimeLeft = GetSkylabTimeLeft(skylab, "promeriumRefinery");
                }
                SkylabData.PromeriumRefineryInfo.Level = int.Parse(levelsRegex[10].Groups[1].Value);

                SkylabData.SepromRefineryInfo.Upgrading = skylab.Contains("timers_sepromRefinery");
                if (SkylabData.SepromRefineryInfo.Upgrading)
                {
                    SkylabData.SepromRefineryInfo.TimeLeft = GetSkylabTimeLeft(skylab, "sepromRefinery");
                }
                SkylabData.SepromRefineryInfo.Level = int.Parse(levelsRegex[11].Groups[1].Value);
            }
            catch { } //if not all modules build it will throw an exception

            

            SkylabData.IsSending = skylab.Contains("timers_activeTransport");

            SkylabData.PromeriumAmount = int.Parse(Regex.Match(skylab, "<td><strong>Promerium</strong></td>[\\n\\r\\s]+<td>(.*?)</td>").Groups[1].Value.Replace(",", ""));
            SkylabData.SepromAmount = int.Parse(Regex.Match(skylab, "<td><strong>Seprom</strong></td>[\\n\\r\\s]+<td>(.*?)</td>").Groups[1].Value.Replace(",", ""));
        }

        private TimeSpan GetSkylabTimeLeft(string pageSource, string module)
        {
            var regFound = Regex.Match(pageSource, "tmp\\.init\\(\\s*\'" + module + "\',\\s*(.*?),\\s*(.*?)\\s*\\);");
            var dateEndSeconds = int.Parse(regFound.Groups[2].Value);
            return dateEndSeconds.TimestampToDate().Subtract(DateTime.Now);
        }

        public async Task<bool> UpgradeSkylabAsync(string type)
        {
            var techFactory = await _httpClient.GetAsyncLimit(Urls.Build(Urls.InternalSkylab));
            var reloadToken = Regex.Match(techFactory, "reloadToken=(.*?)'").Groups[1].Value;
            await Task.Delay(1500);
            var result = await _httpClient.GetAsyncLimit(string.Format(Urls.UpgradeSkylab, Urls.BaseUrl, type, reloadToken));

            //TODO: check if upgrade was success
            return true;
        }

        public async Task ReadTechFactoryAsync()
        {
            var techFactory = await _httpClient.GetAsyncLimit(Urls.Build(Urls.InternalNanoTechFactory));

            var activeHalls = Regex.Matches(techFactory, "hall_singleView hall_active").Count;
            var techAmounts = Regex.Matches(techFactory, "<div class=\"hall_stackBuffNumber\">(.*?)</div>");

            if (activeHalls == 1)
            {
                TechFactoryData.Hall1.Enabled = true;
                //key, level, slot
                var tech = Regex.Match(techFactory, "User.nanoTechFactoryShowBuff\\('(.*?)','1','1'\\)").Groups[1].Value;
                TechFactoryData.Hall1.Item = tech.TechItemFromShortName();
                TechFactoryData.Hall1.Building = Regex.IsMatch(techFactory, "(remainingTime_1)");
                if (TechFactoryData.Hall1.Building)
                {
                    TechFactoryData.Hall1.TimeLeft = TimeSpan.FromSeconds(int.Parse(Regex.Match(techFactory, "counter\\[1\\] = (.*?);").Groups[1].Value));
                }
                TechFactoryData.Hall1.Amount = int.Parse(techAmounts[0].Groups[1].Value);
            }
            else if (activeHalls == 2)
            {
                TechFactoryData.Hall2.Enabled = true;
                var tech = Regex.Match(techFactory, "User.nanoTechFactoryShowBuff\\('(.*?)','1','2'\\)").Groups[1].Value;
                TechFactoryData.Hall2.Item = tech.TechItemFromShortName();
                TechFactoryData.Hall2.Building = Regex.IsMatch(techFactory, "(remainingTime_2)");
                if (TechFactoryData.Hall2.Building)
                {
                    TechFactoryData.Hall2.TimeLeft = TimeSpan.FromSeconds(int.Parse(Regex.Match(techFactory, "counter\\[2\\] = (.*?);").Groups[1].Value));
                }
                TechFactoryData.Hall2.Amount = int.Parse(techAmounts[1].Groups[1].Value);
            }

            else if (activeHalls == 3)
            {
                TechFactoryData.Hall3.Enabled = true;
                var tech = Regex.Match(techFactory, "User.nanoTechFactoryShowBuff\\('(.*?)','1','3'\\)").Groups[1].Value;
                TechFactoryData.Hall3.Item = tech.TechItemFromShortName();
                TechFactoryData.Hall3.Building = Regex.IsMatch(techFactory, "(remainingTime_3)");

                if (TechFactoryData.Hall3.Building)
                {
                    TechFactoryData.Hall3.TimeLeft = TimeSpan.FromSeconds(int.Parse(Regex.Match(techFactory, "counter\\[3\\] = (.*?);").Groups[1].Value));
                }

                TechFactoryData.Hall3.Amount = int.Parse(techAmounts[2].Groups[1].Value);
            }
        }

        public async Task<bool> BuildTechAsync(TechFactoryData.TechFactoryItem item, int slot)
        {
            var techFactory = await _httpClient.GetAsyncLimit(Urls.Build(Urls.InternalNanoTechFactory));
            var reloadToken = Regex.Match(techFactory, "reloadToken=(.*?)'").Groups[1].Value;
            var result = await _httpClient.GetAsyncLimit(string.Format(Urls.BuildTech, Urls.BaseUrl, item.GetShortName(), slot, reloadToken));

            //TODO: check if build was success
            return true;
        }

        public async Task<GateSpinData> SpinGateAsync(GalaxyGate gate)
        {
            var spinUrl = string.Format(Urls.SpinGate, Urls.BaseUrl, AccountData.UserId, AccountData.SessionId,
                (int) gate, gate.GetFullName().ToLower());
            if (GateData.Samples > 0)
            {
                spinUrl = string.Format(Urls.SpinGateSample, Urls.BaseUrl, AccountData.UserId, AccountData.SessionId,
                    (int)gate, gate.GetFullName().ToLower());
            }

            var resultString = await _httpClient.GetAsyncNoLimit(spinUrl);

            var serializer = new XmlSerializer(typeof(GateSpinData));

            GateSpinData result;

            using (var reader = new StringReader(resultString))
            {
                result = (GateSpinData)serializer.Deserialize(reader);
            }


            EvaluateGateSpin(result);

            return result;
        }

        private void EvaluateGateSpin(GateSpinData spin)
        {
            GateItemsReceived.TotalSpins++;
            GateData.Samples = spin.Samples;
            GateData.EnergyCost.Text = spin.EnergyCost.Text;
            GateData.Money = spin.Money;


            foreach (var spinItem in spin.Items.GetAllItems())
            {
                if (spinItem.Type == "part")
                {
                    GateItemsReceived.GateParts++;
                    var gate = GateData.Gates.Gates.Find(x => x.Id == spinItem.GateId);
                    if (gate != null)
                    {
                        gate.Total = spinItem.Total;
                        gate.Current = spinItem.Current;
                    }
                }

                if (spinItem.Type == "battery")
                {
                    switch (spinItem.ItemId)
                    {
                        case 2:
                            GateItemsReceived.X2 += spinItem.Amount;
                            break;
                        case 3:
                            GateItemsReceived.X3 += spinItem.Amount;
                            break;
                        case 4:
                            GateItemsReceived.X4 += spinItem.Amount;
                            break;
                        case 5:
                            GateItemsReceived.SAB += spinItem.Amount;
                            break;
                    }
                }

                if (spinItem.Type == "ore" && spinItem.ItemId == 4)
                {
                    GateItemsReceived.Xenomit += spinItem.Amount;
                }

                if (spinItem.Type == "rocket")
                {
                    switch (spinItem.ItemId)
                    {
                        case 3:
                            GateItemsReceived.PLT2021 += spinItem.Amount;
                            break;
                        case 11:
                            GateItemsReceived.ACM += spinItem.Amount;
                            break;
                    }
                }

                if (spinItem.Type == "logfile")
                {
                    GateItemsReceived.LogDisks += spinItem.Amount;
                }

                if (spinItem.Type == "voucher")
                {
                    GateItemsReceived.RepairCredits += spinItem.Amount;
                }

                if (spinItem.Type == "nanohull")
                {
                    GateItemsReceived.NanoHull += spinItem.Amount;
                }
            }
        }

        public async Task ReadGatesAsync()
        {
            var resultString = await _httpClient.GetAsyncLimit(string.Format(Urls.GateInfo, Urls.BaseUrl, AccountData.UserId, AccountData.SessionId));

            var serializer = new XmlSerializer(typeof(GateData));

            using (var reader = new StringReader(resultString))
            {
                GateData = (GateData)serializer.Deserialize(reader);
            }
        }

        public async Task<bool> PlaceGateAsync(GalaxyGate gate)
        {
            var placed = await _httpClient.GetAsyncLimit(string.Format(Urls.PlaceGate, Urls.BaseUrl, AccountData.UserId,
                AccountData.SessionId, (int) gate));

            return !placed.Contains("not_enough_parts");
        }
    }
}

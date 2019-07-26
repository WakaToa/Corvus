using System;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.Remoting.Lifetime;
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

            EvaluateSkylabAsync(skylab);
        }

        private void EvaluateSkylabAsync(string skylabSource)
        {
            try
            {
                SkylabData.BaseModuleInfo.Upgrading = skylabSource.Contains($"timers_{SkylabData.BaseModuleName}");
                if (SkylabData.BaseModuleInfo.Upgrading)
                {
                    SkylabData.BaseModuleInfo.TimeLeft = GetSkylabTimeLeft(skylabSource, SkylabData.BaseModuleName);
                }
                SkylabData.BaseModuleInfo.Level = GetSkylabModuleLevel(skylabSource, SkylabData.BaseModuleName);

                SkylabData.SolarModuleInfo.Upgrading = skylabSource.Contains($"timers_{SkylabData.SolarModuleName}");
                if (SkylabData.SolarModuleInfo.Upgrading)
                {
                    SkylabData.SolarModuleInfo.TimeLeft = GetSkylabTimeLeft(skylabSource, SkylabData.SolarModuleName);
                }
                SkylabData.SolarModuleInfo.Level = GetSkylabModuleLevel(skylabSource, SkylabData.SolarModuleName);

                SkylabData.StorageModuleInfo.Upgrading = skylabSource.Contains($"timers_{SkylabData.StorageModuleName}");
                if (SkylabData.StorageModuleInfo.Upgrading)
                {
                    SkylabData.StorageModuleInfo.TimeLeft = GetSkylabTimeLeft(skylabSource, SkylabData.StorageModuleName);
                }
                SkylabData.StorageModuleInfo.Level = GetSkylabModuleLevel(skylabSource, SkylabData.StorageModuleName);

                SkylabData.XenoModuleInfo.Upgrading = skylabSource.Contains($"timers_{SkylabData.XenoModuleName}");
                if (SkylabData.XenoModuleInfo.Upgrading)
                {
                    SkylabData.XenoModuleInfo.TimeLeft = GetSkylabTimeLeft(skylabSource, SkylabData.XenoModuleName);
                }
                SkylabData.XenoModuleInfo.Level = GetSkylabModuleLevel(skylabSource, SkylabData.XenoModuleName);

                SkylabData.PrometiumCollectorInfo.Upgrading = skylabSource.Contains($"timers_{SkylabData.PrometiumCollectorName}");
                if (SkylabData.PrometiumCollectorInfo.Upgrading)
                {
                    SkylabData.PrometiumCollectorInfo.TimeLeft = GetSkylabTimeLeft(skylabSource, SkylabData.PrometiumCollectorName);
                }
                SkylabData.PrometiumCollectorInfo.Level = GetSkylabModuleLevel(skylabSource, SkylabData.PrometiumCollectorName);

                SkylabData.EnduriumCollectorInfo.Upgrading = skylabSource.Contains($"timers_{SkylabData.EnduriumCollectorName}");
                if (SkylabData.EnduriumCollectorInfo.Upgrading)
                {
                    SkylabData.EnduriumCollectorInfo.TimeLeft = GetSkylabTimeLeft(skylabSource, SkylabData.EnduriumCollectorName);
                }
                SkylabData.EnduriumCollectorInfo.Level = GetSkylabModuleLevel(skylabSource, SkylabData.EnduriumCollectorName);

                SkylabData.TerbiumCollectorInfo.Upgrading = skylabSource.Contains($"timers_{SkylabData.TerbiumCollectorName}");
                if (SkylabData.TerbiumCollectorInfo.Upgrading)
                {
                    SkylabData.TerbiumCollectorInfo.TimeLeft = GetSkylabTimeLeft(skylabSource, SkylabData.TerbiumCollectorName);
                }
                SkylabData.TerbiumCollectorInfo.Level = GetSkylabModuleLevel(skylabSource, SkylabData.TerbiumCollectorName);

                SkylabData.PrometidRefineryInfo.Upgrading = skylabSource.Contains($"timers_{SkylabData.PrometidRefineryName}");
                if (SkylabData.PrometidRefineryInfo.Upgrading)
                {
                    SkylabData.PrometidRefineryInfo.TimeLeft = GetSkylabTimeLeft(skylabSource, SkylabData.PrometidRefineryName);
                }
                SkylabData.PrometidRefineryInfo.Level = GetSkylabModuleLevel(skylabSource, SkylabData.PrometidRefineryName);

                SkylabData.DuraniumRefineryInfo.Upgrading = skylabSource.Contains($"timers_{SkylabData.DuraniumRefineryName}");
                if (SkylabData.DuraniumRefineryInfo.Upgrading)
                {
                    SkylabData.DuraniumRefineryInfo.TimeLeft = GetSkylabTimeLeft(skylabSource, SkylabData.DuraniumRefineryName);
                }
                SkylabData.DuraniumRefineryInfo.Level = GetSkylabModuleLevel(skylabSource, SkylabData.DuraniumRefineryName);

                SkylabData.PromeriumRefineryInfo.Upgrading = skylabSource.Contains($"timers_{SkylabData.PromeriumRefineryName}");
                if (SkylabData.PromeriumRefineryInfo.Upgrading)
                {
                    SkylabData.PromeriumRefineryInfo.TimeLeft = GetSkylabTimeLeft(skylabSource, SkylabData.PromeriumRefineryName);
                }
                SkylabData.PromeriumRefineryInfo.Level = GetSkylabModuleLevel(skylabSource, SkylabData.PromeriumRefineryName);

                SkylabData.SepromRefineryInfo.Upgrading = skylabSource.Contains($"timers_{SkylabData.SepromRefineryName}");
                if (SkylabData.SepromRefineryInfo.Upgrading)
                {
                    SkylabData.SepromRefineryInfo.TimeLeft = GetSkylabTimeLeft(skylabSource, SkylabData.SepromRefineryName);
                }
                SkylabData.SepromRefineryInfo.Level = GetSkylabModuleLevel(skylabSource, SkylabData.SepromRefineryName);
            }
            catch { }



            SkylabData.IsSending = skylabSource.Contains("timers_activeTransport");

            }

        private TimeSpan GetSkylabTimeLeft(string pageSource, string module)
        {
            var regFound = Regex.Match(pageSource, "tmp\\.init\\(\\s*\'" + module + "\',\\s*(.*?),\\s*(.*?)\\s*\\);");
            var dateEndSeconds = int.Parse(regFound.Groups[2].Value);
            return dateEndSeconds.TimestampToDate().Subtract(DateTime.Now);
        }

        private int GetSkylabModuleLevel(string pageSource, string module)
        {
            
            var r = Regex.Match(pageSource,
                module +
                "\'\\);\"\">[a-zA-z0-9\\\"_<>=\\-\\/\\s]*(.*?)<\\/div>[a-zA-z0-9\\\"_<>=\\-\\/\\s]*skylab_font_level(_inactive)?\">(.*?)<\\/div>");
            if (!r.Success)
            {
                return 0;
            }

            return int.Parse(r.Groups[3].Value);
        }

        public async Task<bool> UpgradeSkylabAsync(string module)
        {
            var techFactory = await _httpClient.GetAsyncLimit(Urls.Build(Urls.InternalSkylab));
            var reloadToken = Regex.Match(techFactory, "reloadToken=(.*?)'").Groups[1].Value;
            await Task.Delay(1500);
            var result = await _httpClient.GetAsyncLimit(string.Format(Urls.UpgradeSkylab, Urls.BaseUrl, module, reloadToken));
            
            EvaluateSkylabAsync(result);

            if (SkylabData.GetByString(module) != null)
            {
                return SkylabData.GetByString(module).Upgrading;
            }

            return false;
        }

        public async Task ReadTechFactoryAsync()
        {
            var techFactory = await _httpClient.GetAsyncLimit(Urls.Build(Urls.InternalNanoTechFactory));

            EvaluateTechFactory(techFactory);
        }

        private void EvaluateTechFactory(string techFactorySource)
        {
            var activeHalls = Regex.Matches(techFactorySource, "hall_singleView hall_active").Count;
            var techAmounts = Regex.Matches(techFactorySource, "<div class=\"hall_stackBuffNumber\">(.*?)</div>");

            if (activeHalls >= 1)
            {
                TechFactoryData.Hall1.Enabled = true;
                //key, level, slot
                var tech = Regex.Match(techFactorySource, "User.nanoTechFactoryShowBuff\\('(.*?)','1','1'\\)").Groups[1].Value;
                TechFactoryData.Hall1.Item = tech.TechItemFromShortName();
                TechFactoryData.Hall1.Building = Regex.IsMatch(techFactorySource, "(remainingTime_1)");
                if (TechFactoryData.Hall1.Building)
                {
                    TechFactoryData.Hall1.TimeLeft = TimeSpan.FromSeconds(int.Parse(Regex.Match(techFactorySource, "counter\\[1\\] = (.*?);").Groups[1].Value));
                }

                if (techAmounts.Count >= 1 && techAmounts[0].Groups[1].Success)
                {
                    TechFactoryData.Hall1.Amount = int.Parse(techAmounts[0].Groups[1].Value);
                }
                
            }
            if (activeHalls >= 2)
            {
                TechFactoryData.Hall2.Enabled = true;
                var tech = Regex.Match(techFactorySource, "User.nanoTechFactoryShowBuff\\('(.*?)','1','2'\\)").Groups[1].Value;
                TechFactoryData.Hall2.Item = tech.TechItemFromShortName();
                TechFactoryData.Hall2.Building = Regex.IsMatch(techFactorySource, "(remainingTime_2)");
                if (TechFactoryData.Hall2.Building)
                {
                    TechFactoryData.Hall2.TimeLeft = TimeSpan.FromSeconds(int.Parse(Regex.Match(techFactorySource, "counter\\[2\\] = (.*?);").Groups[1].Value));
                }

                if (techAmounts.Count >= 2 && techAmounts[1].Groups[1].Success)
                {
                    TechFactoryData.Hall2.Amount = int.Parse(techAmounts[1].Groups[1].Value);
                }
            }

            if (activeHalls >= 3)
            {
                TechFactoryData.Hall3.Enabled = true;
                var tech = Regex.Match(techFactorySource, "User.nanoTechFactoryShowBuff\\('(.*?)','1','3'\\)").Groups[1].Value;
                TechFactoryData.Hall3.Item = tech.TechItemFromShortName();
                TechFactoryData.Hall3.Building = Regex.IsMatch(techFactorySource, "(remainingTime_3)");

                if (TechFactoryData.Hall3.Building)
                {
                    TechFactoryData.Hall3.TimeLeft = TimeSpan.FromSeconds(int.Parse(Regex.Match(techFactorySource, "counter\\[3\\] = (.*?);").Groups[1].Value));
                }

                if (techAmounts.Count >= 3 && techAmounts[2].Groups[1].Success)
                {
                    TechFactoryData.Hall3.Amount = int.Parse(techAmounts[2].Groups[1].Value);
                }
            }
        }

        public async Task<bool> BuildTechAsync(TechFactoryData.TechFactoryItem item, int hall)
        {
            var techFactoryRaw = await _httpClient.PostAsyncLimitRaw(Urls.Build("{0}/ajax/nanotechFactory.php"), $"command=nanoTechFactoryShowBuff&key={item.GetShortName()}&level=1");
            var techFactory = await techFactoryRaw.Content.ReadAsStringAsync();
            var reloadToken = Regex.Match(techFactory, "reloadToken=(.*?)\"").Groups[1].Value;
            await Task.Delay(1500);
            var result = await _httpClient.GetAsyncLimit(string.Format(Urls.BuildTech, Urls.BaseUrl, item.GetShortName(), reloadToken));

            EvaluateTechFactory(result);

            if (TechFactoryData.GetById(hall) != null)
            {
                return TechFactoryData.GetById(hall).Building;
            }

            return false;
        }

        private bool IsMultiplierAvailable(GalaxyGate gate)
        {
            var gateName = gate.GetFullName().ToLower();

            var data = GateData.MultiplierInfo.MultiplierInfo.FirstOrDefault(x => x.Mode.ToLower() == gateName);
            if (data == null)
            {
                return false;
            }
            return data.Value >= 0;
        }

        public async Task<GateSpinData> SpinGateAsync(GalaxyGate gate, bool useMultiplier, int spinamount)
        {
            var spinUrl = string.Empty;
            if (useMultiplier && IsMultiplierAvailable(gate))
            {
                if(spinamount == 1)
                {
                    spinUrl = string.Format(Urls.SpinGateMultiplier, Urls.BaseUrl, AccountData.UserId, AccountData.SessionId,
                       (int)gate, gate.GetFullName().ToLower());

                    if (GateData.Samples > 0)
                    {
                        spinUrl = string.Format(Urls.SpinGateSampleMultiplier, Urls.BaseUrl, AccountData.UserId, AccountData.SessionId,
                            (int)gate, gate.GetFullName().ToLower());
                    }
                } else
                {
                    spinUrl = string.Format(Urls.SpinGateMultiplierAmount, Urls.BaseUrl, AccountData.UserId, AccountData.SessionId,
                    (int)gate, gate.GetFullName().ToLower(), spinamount);

                    if (GateData.Samples > 0)
                    {
                        spinUrl = string.Format(Urls.SpinGateSampleMultiplierAmount, Urls.BaseUrl, AccountData.UserId, AccountData.SessionId,
                            (int)gate, gate.GetFullName().ToLower(), spinamount);
                    }
                }               
            }
            else
            {
                if(spinamount == 1)
                {
                    spinUrl = string.Format(Urls.SpinGate, Urls.BaseUrl, AccountData.UserId, AccountData.SessionId,
                        (int)gate, gate.GetFullName().ToLower());

                    if (GateData.Samples > 0)
                    {
                        spinUrl = string.Format(Urls.SpinGateSample, Urls.BaseUrl, AccountData.UserId, AccountData.SessionId,
                            (int)gate, gate.GetFullName().ToLower());
                    }
                }
                else
                {
                    spinUrl = string.Format(Urls.SpinGateAmount, Urls.BaseUrl, AccountData.UserId, AccountData.SessionId,
                        (int)gate, gate.GetFullName().ToLower(), spinamount);

                    if (GateData.Samples > 0)
                    {
                        spinUrl = string.Format(Urls.SpinGateSampleAmount, Urls.BaseUrl, AccountData.UserId, AccountData.SessionId,
                            (int)gate, gate.GetFullName().ToLower(), spinamount);
                    }
                }
            }

            var resultString = string.Empty;
            try
            {
                resultString = await _httpClient.GetAsyncNoLimit(spinUrl);

                var serializer = new XmlSerializer(typeof(GateSpinData));

                GateSpinData result;

                using (var reader = new StringReader(resultString))
                {
                    result = (GateSpinData)serializer.Deserialize(reader) as GateSpinData;
                }
                EvaluateGateSpin(result, spinamount);

                return result;
            }
            catch (Exception e)
            {
                return default(GateSpinData);
            }

            
        }

        private void EvaluateGateSpin(GateSpinData spin, int spinamount)
        {
            try
            {
                GateItemsReceived.TotalSpins += spinamount;
                GateData.Samples = spin.Samples;
                GateData.EnergyCost.Text = spin.EnergyCost.Text;
                GateData.Money = spin.Money;

                GateData.MultiplierInfo = spin.MultiplierInfo;

                foreach (var spinItem in spin.Items.GetAllItems())
                {
                    if (spinItem.Type == "part" && !spinItem.Duplicate)
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
            catch (Exception e)
            {
            }            
        }

        public async Task ReadGatesAsync()
        {
            var resultString = await _httpClient.GetAsyncLimit(string.Format(Urls.GateInfo, Urls.BaseUrl, AccountData.UserId, AccountData.SessionId));

            XmlSerializer serializer = new XmlSerializer(typeof(GateData));

            using (var reader = new StringReader(resultString))
            {
                GateData = (GateData)serializer.Deserialize(reader) as GateData;
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

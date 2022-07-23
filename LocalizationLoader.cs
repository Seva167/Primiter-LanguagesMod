using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seva167.LanguagesMod
{
    static class LocalizationLoader
    {
        public static void LoadLocalization(Localization locale)
        {
            foreach (var pair in locale.Dictionary)
            {
                Localizer.table.RemoveEntry(pair.Key);
                Localizer.table.AddEntry(pair.Key, pair.Value);
            }
        }

        public static Localization ReadLocalizationFromJson(string path)
        {
            try
            {
                string json = File.ReadAllText(path);
                Localization localization = JsonConvert.DeserializeObject<Localization>(json);
                localization.Code = Path.GetFileNameWithoutExtension(path);
                return localization;
            }
            catch (Exception e)
            {
                PrimitierModdingFramework.PMFLog.Message(e.Message + e.StackTrace);
                return null;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;
using PrimitierModdingFramework;

namespace Seva167.LanguagesMod
{
    public static class LocalizationDumper
    {
        public static void DumpLocalization()
        {
            string dumpPath = Mod.LocalizationsFolder + @"Dumps\";
            Dictionary<string, string> dumpedDictionary = new Dictionary<string, string>();

            for (int i = 0; i < Localizer.table.Count; i++)
            {
                dumpedDictionary.Add(Localizer.table.SharedData.Entries[i].Key, Localizer.GetLocalizedString(Localizer.table.SharedData.Entries[i].Key));
            }

            Localization dumpedLocalization = new Localization
            {
                Name = Localizer.table.LocaleIdentifier.CultureInfo.nativename,
                Dictionary = dumpedDictionary
            };

            if (!Directory.Exists(dumpPath))
                Directory.CreateDirectory(dumpPath);

            string savePath = dumpPath + Localizer.table.LocaleIdentifier.Code + ".json";
            string json = JsonConvert.SerializeObject(dumpedLocalization, Formatting.Indented);
            File.WriteAllText(savePath, json);
            PMFLog.Message($"Dumped localization file: {savePath}");
        }
    }
}

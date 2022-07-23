using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using UnityEngine.Localization.Settings;

namespace Seva167.LanguagesMod
{
    static class LanguageManager
    {
        public static UnityEngine.Localization.Locale[] UnityLocales { get; private set; }

        private static Localization[] locales;

        public static void LoadAllLocales()
        {
            string[] localeFiles = Directory.GetFiles(Mod.LocalizationsFolder);
            locales = new Localization[localeFiles.Length];
            UnityLocales = new UnityEngine.Localization.Locale[localeFiles.Length];
            for (int i = 0; i < locales.Length; i++)
            {
                locales[i] = LocalizationLoader.ReadLocalizationFromJson(localeFiles[i]);
                UnityLocales[i] = UnityEngine.Localization.Locale.CreateLocale(locales[i].Code);
                UnityLocales[i].LocaleName = locales[i].Name;
            }
            
        }

        public static Localization GetLocalizationFromUnityLocale(UnityEngine.Localization.Locale locale)
        {
            foreach (var localization in locales)
            {
                if (locale.Identifier.Code == localization.Code)
                    return localization;
            }
            return null;
        }
    }
}

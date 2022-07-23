using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HarmonyLib;

namespace Seva167.LanguagesMod.Patches
{
    [HarmonyPatch(typeof(Localizer), nameof(Localizer.OnLocaleChanged))]
    public class OnLocaleChangedPatch
    {
        static void Postfix(UnityEngine.Localization.Locale locale)
        {
            LocalizationLoader.LoadLocalization(LanguageManager.GetLocalizationFromUnityLocale(locale));
        }
    }
}

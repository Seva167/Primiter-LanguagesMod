using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Seva167.LanguagesMod.UI
{
    public class LanguageSelector : MonoBehaviour
    {
        public LanguageSelector(System.IntPtr ptr) : base(ptr) { }

        public SelectLocaleButton SelectButton { get; set; }

        public TMPro.TextMeshPro SelectionText { get; set; }

        int localeIndex = 0;

        public void NextLanguage()
        {
            localeIndex++;

            if (localeIndex == LanguageManager.UnityLocales.Length)
                localeIndex = 0;

            SelectionText.text = LanguageManager.UnityLocales[localeIndex].LocaleName;
            SelectButton.Locale = LanguageManager.UnityLocales[localeIndex];
        }
    }
}

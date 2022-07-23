using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Seva167.LanguagesMod.UI
{
    public class SelectLocaleButton : MonoBehaviour
    {
        public SelectLocaleButton(System.IntPtr ptr) : base(ptr) { }

        public UnityEngine.Localization.Locale Locale { get; set; }

        public void OnPress()
        {
            Localizer.OnLocaleChanged(Locale);
        }
    }
}

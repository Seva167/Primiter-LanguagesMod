using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Seva167.LanguagesMod.UI
{
    public class NextLanguageButton : MonoBehaviour
    {
        public NextLanguageButton(System.IntPtr ptr) : base(ptr) { }

        public LanguageSelector Selector { get; set; }

        public void OnPress()
        {
            Selector.NextLanguage();
        }
    }
}

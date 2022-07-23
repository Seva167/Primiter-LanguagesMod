using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using TMPro;
using PrimitierModdingFramework;
using Seva167.LanguagesMod.UI;

namespace Seva167.LanguagesMod
{
    static class LanguangeSelectorFactory
    {
        public static void CreateLanguageSelector(UnityEngine.Localization.Locale initialLocale)
        {
            Transform titleSpace = GameObject.Find("TitleSpace").transform;
            // Container
            GameObject selectorObj = new GameObject("LanguageSelector");
            selectorObj.transform.parent = titleSpace;
            selectorObj.transform.localPosition = new Vector3(0.2f, 0.2f, 1.9f);
            selectorObj.transform.localRotation = Quaternion.identity;
            selectorObj.transform.localScale = Vector3.one;

            GameObject selectionTextObj = new GameObject("Text");
            selectionTextObj.transform.parent = selectorObj.transform;
            selectionTextObj.transform.localPosition = Vector3.zero;
            selectionTextObj.transform.localRotation = Quaternion.identity;
            selectionTextObj.transform.localScale = Vector3.one;
            TextMeshPro languageSelectionText = selectionTextObj.AddComponent<TextMeshPro>();
            languageSelectionText.autoSizeTextContainer = true;
            languageSelectionText.font = PMFHelper.PrimitierDefaultFont;
            languageSelectionText.color = Color.black;
            languageSelectionText.fontSize = .8f;
            languageSelectionText.text = initialLocale.LocaleName;

            LanguageSelector languageSelectorBeh = selectorObj.AddComponent<LanguageSelector>();


            // Next Button
            GameObject changeLocaleBtn = new GameObject("NextButton");
            changeLocaleBtn.transform.parent = titleSpace;
            changeLocaleBtn.transform.localPosition = new Vector3(0f, 0.4f, 1.95f);
            changeLocaleBtn.transform.localRotation = Quaternion.identity;
            changeLocaleBtn.transform.localScale = Vector3.one;

            GameObject changeLocaleCube = GameObject.CreatePrimitive(PrimitiveType.Cube);
            changeLocaleCube.transform.parent = changeLocaleBtn.transform;
            changeLocaleCube.transform.localPosition = Vector3.zero;
            changeLocaleCube.transform.localRotation = Quaternion.identity;
            changeLocaleCube.transform.localScale = new Vector3(0.3f, 0.3f, 0.15f);

            GameObject changeLocaleTextCont = new GameObject("Text");
            changeLocaleTextCont.transform.parent = changeLocaleBtn.transform;
            changeLocaleTextCont.transform.localPosition = new Vector3(0f, 0f, -0.081f);
            changeLocaleTextCont.transform.localRotation = Quaternion.identity;
            TextMeshPro changeLocaleTxt = changeLocaleTextCont.AddComponent<TextMeshPro>();
            changeLocaleTxt.autoSizeTextContainer = true;
            changeLocaleTxt.font = PMFHelper.PrimitierDefaultFont;
            changeLocaleTxt.color = Color.black;
            changeLocaleTxt.fontSize = .8f;
            changeLocaleTxt.text = "Next";

            NextLanguageButton changeLocaleBeh = changeLocaleBtn.AddComponent<NextLanguageButton>();
            changeLocaleBeh.Selector = languageSelectorBeh;
            languageSelectorBeh.SelectionText = languageSelectionText;


            // Select Button
            GameObject selectLocaleBtn = new GameObject("SelectButton");
            selectLocaleBtn.transform.parent = titleSpace;
            selectLocaleBtn.transform.localPosition = new Vector3(0.4f, 0.4f, 1.95f);
            selectLocaleBtn.transform.localRotation = Quaternion.identity;
            selectLocaleBtn.transform.localScale = Vector3.one;

            GameObject selectLocaleCube = GameObject.CreatePrimitive(PrimitiveType.Cube);
            selectLocaleCube.transform.parent = selectLocaleBtn.transform;
            selectLocaleCube.transform.localPosition = Vector3.zero;
            selectLocaleCube.transform.localRotation = Quaternion.identity;
            selectLocaleCube.transform.localScale = new Vector3(0.3f, 0.3f, 0.15f);

            GameObject selectLocaleTextCont = new GameObject("Text");
            selectLocaleTextCont.transform.parent = selectLocaleBtn.transform;
            selectLocaleTextCont.transform.localPosition = new Vector3(0f, 0f, -0.081f);
            selectLocaleTextCont.transform.localRotation = Quaternion.identity;
            TextMeshPro selectLocaleTxt = selectLocaleTextCont.AddComponent<TextMeshPro>();
            selectLocaleTxt.autoSizeTextContainer = true;
            selectLocaleTxt.font = PMFHelper.PrimitierDefaultFont;
            selectLocaleTxt.color = Color.black;
            selectLocaleTxt.fontSize = .8f;
            selectLocaleTxt.text = "Select";


            SelectLocaleButton selectLocaleBeh = selectLocaleBtn.AddComponent<SelectLocaleButton>();
            selectLocaleBeh.Locale = initialLocale;
            languageSelectorBeh.SelectButton = selectLocaleBeh;
        }
    }
}

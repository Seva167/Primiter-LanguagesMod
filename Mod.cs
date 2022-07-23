using Il2CppSystem;
using PrimitierModdingFramework;
using UnityEngine;
using UnhollowerBaseLib;
using UnhollowerRuntimeLib;
using System.IO;
using PrimitierModdingFramework.Debugging;

namespace Seva167.LanguagesMod
{
	public class Mod : PrimitierMod
    {
		public static string LocalizationsFolder { get; private set; }

		public override void OnSceneWasLoaded(int buildIndex, string sceneName)
		{
            base.OnSceneWasLoaded(buildIndex, sceneName);

			InGameDebugTool.GetMenu("MainMenu").CreateButton("Dump localization", new System.Action(() =>
			{
				LocalizationDumper.DumpLocalization();
			}));

			if (LanguageManager.UnityLocales.Length > 0)
				LanguangeSelectorFactory.CreateLanguageSelector(LanguageManager.UnityLocales[0]);


            foreach (var locale in LanguageManager.UnityLocales)
            {
				if (locale.Identifier.Code == Config.Data.localeCode)
					Localizer.OnLocaleChanged(locale);
            }

		}

        public override void OnApplicationStart()
		{
            base.OnApplicationStart();

            PMFSystem.EnableSystem<PMFHelper>();
			PMFSystem.EnableSystem<InGameDebuggingSystem>();

			ClassInjector.RegisterTypeInIl2Cpp<UI.LanguageSelector>(true);
			ClassInjector.RegisterTypeInIl2CppWithInterfaces<UI.NextLanguageButton>(typeof(IButton));
			ClassInjector.RegisterTypeInIl2CppWithInterfaces<UI.SelectLocaleButton>(typeof(IButton));

			LocalizationsFolder = System.Environment.GetFolderPath(System.Environment.SpecialFolder.MyDocuments) + @"\Primitier\Localizations\";
			if (!Directory.Exists(LocalizationsFolder))
				Directory.CreateDirectory(LocalizationsFolder);

			LanguageManager.LoadAllLocales();
		}
		
	}
}

using Abp.Configuration.Startup;
using Abp.Localization.Dictionaries;
using Abp.Localization.Dictionaries.Xml;
using Abp.Reflection.Extensions;

namespace Osepaishvili_Halyk_Task.Localization
{
    public static class Osepaishvili_Halyk_TaskLocalizationConfigurer
    {
        public static void Configure(ILocalizationConfiguration localizationConfiguration)
        {
            localizationConfiguration.Sources.Add(
                new DictionaryBasedLocalizationSource(Osepaishvili_Halyk_TaskConsts.LocalizationSourceName,
                    new XmlEmbeddedFileLocalizationDictionaryProvider(
                        typeof(Osepaishvili_Halyk_TaskLocalizationConfigurer).GetAssembly(),
                        "Osepaishvili_Halyk_Task.Localization.SourceFiles"
                    )
                )
            );
        }
    }
}

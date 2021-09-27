using Abp.Configuration.Startup;
using Abp.Localization.Dictionaries;
using Abp.Localization.Dictionaries.Xml;
using Abp.Reflection.Extensions;

namespace Assessment.GlobalKinetic.Localization
{
    public static class GlobalKineticLocalizationConfigurer
    {
        public static void Configure(ILocalizationConfiguration localizationConfiguration)
        {
            localizationConfiguration.Sources.Add(
                new DictionaryBasedLocalizationSource(GlobalKineticConsts.LocalizationSourceName,
                    new XmlEmbeddedFileLocalizationDictionaryProvider(
                        typeof(GlobalKineticLocalizationConfigurer).GetAssembly(),
                        "Assessment.GlobalKinetic.Localization.SourceFiles"
                    )
                )
            );
        }
    }
}

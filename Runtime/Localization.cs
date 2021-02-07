using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace WattanaGaming.Localization
{
    public class Localization
    {
        public static string currentLanguage = "en";
        
        public static Dictionary<string, string> GetTextLocalization(LocalizedTextAsset localization, string language)
        {
            Dictionary<string, string> languageDictionary = new Dictionary<string, string>();

            foreach (LocalizedText localizedText in localization.localizedTexts)
            {
                foreach (LocalizedText.TextEntry textEntry in localizedText.textEntries)
                {
                    if (textEntry.language == language)
                    {
                        languageDictionary.Add(localizedText.id, textEntry.text);
                    }
                }
            }

            return languageDictionary;
        }

        public static Dictionary<string, string> GetTextLocalization(LocalizedTextAsset localization)
        {
            return GetTextLocalization(localization, currentLanguage);
        }
    }
}

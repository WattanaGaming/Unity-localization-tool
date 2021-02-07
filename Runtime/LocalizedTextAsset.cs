using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace WattanaGaming.Localization
{
    [CreateAssetMenu(fileName = "New Localized Text Asset", menuName = "Localized Text Asset")]
    public class LocalizedTextAsset : ScriptableObject
    {
        public LocalizedText[] localizedTexts;
    }

    [System.Serializable]
    public struct LocalizedText
    {
        public string id;
        public TextEntry[] textEntries;

        [System.Serializable]
        public struct TextEntry
        {
            public string text;
            public string language;
        }
    }
}

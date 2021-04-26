using System;
using UnityEngine;

namespace MVCReferenceFinder.Editor.Styles
{
    [Serializable]
    internal class ContentStylePair
    {
        public GUIContent Content = new GUIContent();
        public GUIStyle Style = new GUIStyle();
    }
}
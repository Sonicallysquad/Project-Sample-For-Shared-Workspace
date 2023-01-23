using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MiniGameSpinWheel
{

    [CreateAssetMenu(fileName = "Readme", menuName = "ScriptableObjects/Readme")]
    public class ReadMe : ScriptableObject
    {
        [TextArea(3, 5)]
        public string title;

        [TextArea(5, 25)]
        public string[] instructions;
    }
}

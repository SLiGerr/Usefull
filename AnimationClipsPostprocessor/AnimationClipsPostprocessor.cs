#if UNITY_EDITOR
using UnityEditor;
using UnityEngine;

namespace Usefull
{
    public class AnimationClipsPostprocessor : AssetPostprocessor
    {
        private void OnPostprocessAnimation(GameObject g, AnimationClip c) 
        {
            c.name = g.name;
        }
    }
}
#endif
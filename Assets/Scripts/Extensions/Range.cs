using System;
using UnityEngine;

namespace Extensions
{
    [Serializable]
    public struct Range
    {
        [field: SerializeField]
        public float Min { get; private set; }
        
        [field: SerializeField]
        public float Max { get; private set; }
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class NoiseSettings
{
    public enum FilterType {Simple, Ridgid};
    public FilterType filterType;

    public SimpleNoiseSettings simpleNoiseSettings;
    public RidgidNoiseSettings ridgidNoiseSettings;

    [System.Serializable]
    public class SimpleNoiseSettings
    {
        [Range(1, 8)]
        public int numLayers = 1;
        public float persistance = 0.5f;
        public float baseRoughness = 1;
        public float roughness = 1;
        public float strength = 1; 
        public Vector3 center;
        public float minValue;
    }

    [System.Serializable]
    public class RidgidNoiseSettings : SimpleNoiseSettings
    {
        public float weightMultiplier = 0.8f;
    }

    
}

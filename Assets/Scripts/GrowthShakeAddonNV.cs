using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrowthShakeAddonNV : MonoBehaviour
{
    [Range(0,10)] public float maxSize;
    [Range(0,10)] public float minSize;

    void Start()
    {
        Analyzer.onVolumeChanged.AddListener(Grow);
    }
    public void Grow(float volume)
    {
        transform.localScale = Vector3.Lerp(new Vector3(minSize, minSize, minSize), new Vector3(maxSize, maxSize, maxSize), volume);
    }
}

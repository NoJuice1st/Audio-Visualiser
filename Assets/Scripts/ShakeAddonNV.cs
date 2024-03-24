using System.Collections.Generic;
using UnityEngine;

public class ShakeAddonNV : MonoBehaviour
{
    [Range(0,1)] public float shake;
    Vector3 originalPos;

    void Start()
    {
        originalPos = gameObject.transform.position;
        Analyzer.onVolumeChanged.AddListener(Shake);
    }
    public void Shake(float volume)
    {
        transform.position = originalPos + new Vector3(Random.Range(-shake, shake), Random.Range(-shake, shake), Random.Range(-shake, shake)) * volume;
    }
}

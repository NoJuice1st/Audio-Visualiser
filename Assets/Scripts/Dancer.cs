using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dancer : MonoBehaviour
{
    [Range(0,5)] public float rotSpeed;

    void Start()
    {
        Analyzer.onVolumeChanged.AddListener(Dance);
    }
    public void Dance(float volume)
    {
        gameObject.transform.localScale = Vector3.one * volume * 2f;
        transform.position = Vector3.Lerp(new Vector3(0,0,0), new Vector3(3,2,0), volume);
    }
}

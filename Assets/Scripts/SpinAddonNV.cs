using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinAddonNV : MonoBehaviour
{
    [Range(0,1000)] public float rotSpeed;
    public Vector3 rotateDir = Vector3.left;
    [Range(0,359)]public float snapAngle;
    [Range(0,1)]public float maxVolume = 0.3f;
    [Range(0,1)]public float minVolume = 0.2f;


    void Start()
    {
        Analyzer.onVolumeChanged.AddListener(Spin);
    }

    public void Spin(float volume)
    {
        if(snapAngle == 0)transform.Rotate(rotateDir * rotSpeed * volume * Time.deltaTime);
        else if(volume >= minVolume && volume <= maxVolume)  transform.Rotate(rotateDir * snapAngle);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleShootAddonNV : MonoBehaviour
{
    public GameObject particles;

    void Start()
    {
        Analyzer.onVolumeChanged.AddListener(Pop);
    }
    public void Pop(float volume)
    {
        if(volume >= 0.39 && volume <= 0.4)
        {
            var particle = Instantiate(particles, transform.position, transform.rotation);
        }
    }
}

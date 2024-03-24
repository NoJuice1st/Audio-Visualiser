using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

public class GrowthAddonNV : MonoBehaviour
{
    [Range(0,20)] public float maxYSize;
    [Range(0,10)] public float minYSize;
    Vector3 originalPos;

    void Start()
    {
        originalPos = gameObject.transform.position;
        Analyzer.onVolumeChanged.AddListener(Grow);
    }
    public void Grow(float volume)
    {
        
        //transform.localScale = Vector3.Lerp(new Vector3(transform.localScale.x, minYSize, transform.localScale.z), new Vector3(transform.localScale.x, maxYSize, transform.localScale.z), volume);

        var scaleTo = Vector3.Lerp(new Vector3(transform.localScale.x, minYSize, transform.localScale.z), new Vector3(transform.localScale.x, maxYSize, transform.localScale.z), volume);
        transform.DOScale(scaleTo, 0.1f);
        transform.DOMove(originalPos + new Vector3(0, scaleTo.y, 0) / 2, 0.1f);


        //transform.position = originalPos + new Vector3(0, transform.localScale.y, 0) / 2;
    }
}

using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

public class MovementBetweenPointsNV : MonoBehaviour
{
    public Transform ogTrans;
    Vector3 ogPos;
    public Transform newPos;

    void Start()
    {
        if(!ogTrans) ogPos = transform.position; else ogPos = ogTrans.position;
        Analyzer.onVolumeChanged.AddListener(Move);
    }
    
    public void Move(float volume)
    {
        //transform.position = Vector3.Lerp(ogPos, newPos.position, volume);
        transform.DOMove(Vector3.Lerp(ogPos, newPos.position, volume), 0.1f);

    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircleDancer : MonoBehaviour
{
    [Range(1, 50)] public int count = 10;
    [Range(0, 10)] public float radius = 5f;

    [Range(-100, 100)]public float rotateSpeed = 2f;
    [Range(-10, 10)] public float sensitivity = 2f;
    [Range(-5, 5)] public float boost = 1.5f;

    [Range(0, 10)]public float minSize;

    public GameObject prefab;

    void Start()
    {
        for (int i = 0; i < count; i++)
        {
           
            var angle = (float)i / count * Mathf.PI * 2f;

            var pos = new Vector3();
            pos.x = Mathf.Cos(angle);
            pos.y = Mathf.Sin(angle);
            pos *= radius;

            //print(pos);
            var obj = Instantiate(prefab, pos, Quaternion.identity, transform);
            obj.transform.LookAt(transform);
        }

        Analyzer.onVolumeChanged.AddListener(Dance);
    }

    public void Dance(float volume)
    {
        transform.Rotate(0, 0, Mathf.Pow(volume * boost, sensitivity) * rotateSpeed);
        transform.localScale = Vector3.one * volume + Vector3.one * minSize;
    }
}

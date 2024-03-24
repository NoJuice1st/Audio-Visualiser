using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Timeline;

public class TintManager : MonoBehaviour
{
    public Material materialOne;
    public Material materialTwo;
    public Material materialOneBackup;
    public Material materialTwoBackup;

    public Color colorTo1;
    public Color colorTo2;

    void Start()
    {
        materialOne.color = materialOneBackup.color;
        materialTwo.color = materialTwoBackup.color;

        //materialOne.SetColor("_EmissionColor", materialOneBackup.GetColor("_EmissionColor"));
        //materialTwo.SetColor("_EmissionColor", materialTwoBackup.GetColor("_EmissionColor"));

        Analyzer.onVolumeChanged.AddListener(ChangeTints);
    }
    
    public void ChangeTints(float volume)
    {
        var newEmissionOne = Vector4.Lerp(materialOneBackup.color, colorTo1, volume * 2);
        materialOne.color = newEmissionOne;
        materialOne.SetColor("_EmissionColor", newEmissionOne);

        var newEmissionTwo = Vector4.Lerp(materialTwoBackup.color, colorTo2, volume * 2);
        materialTwo.color = newEmissionTwo;
        materialTwo.SetColor("_EmissionColor", newEmissionTwo);

    }
}

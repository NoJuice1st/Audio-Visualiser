using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using TMPro;

public class UIManager : MonoBehaviour
{
    static UIManager menuManager;
    private bool isHidden = false;

    private void Start()
    {
        DOTween.SetTweensCapacity(500, 50);
        if (!menuManager)
        {
            menuManager = this;
            DontDestroyOnLoad(menuManager);
        }
        else
        {
            Destroy(gameObject);
        }

        
    }

    public void ToggleMenu(GameObject panel)
    {
        if(!isHidden)
        {
            var rectTrans = panel.GetComponent<RectTransform>();
            rectTrans.DOMoveY(-rectTrans.sizeDelta.y * 2.2f, 0.1f);
            isHidden = true;
        }
        else
        {
            var rectTrans = panel.GetComponent<RectTransform>();
            rectTrans.DOMoveY(0, 0.1f);
            isHidden = false;
        }
    }

    public void ToggleText(TMP_Text text)
    {
        if (!isHidden)
        {
            text.text = ">";
        }
        else
        {
            text.text = "<";
        }
    }

    public void ChangeVolume(float vol)
    {

    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class sceneFade : MonoBehaviour
{
    private float currentAlpha = 10f;
    private CanvasGroup fade;
    private bool IsIn;
    private float highestValue = 10f;
    private float lowestValue = 0f;
    private bool Isready = false;

    void Start()
    {
        fade = GetComponent<CanvasGroup>();
        fade.alpha = 1f;

        IsIn = true;
    }

    void Update()
    {
        if (IsIn)
        {
            currentAlpha -= Time.deltaTime * 8;
        }
        else
        {
            currentAlpha += Time.deltaTime * 8;
        }

        if (currentAlpha > highestValue)
        {
            currentAlpha = highestValue;
            Isready = true;
        }
        else if (currentAlpha < lowestValue)
        {
            currentAlpha = lowestValue;
            Isready = false;
        }


        fade.alpha = currentAlpha / 10;
    }
    public void OnFadeIN()
    {
        IsIn = true;
    }

    public void OnFadeOut()
    {
        IsIn = false;
    }

    public bool ready()
    {
        return Isready;
    }
}

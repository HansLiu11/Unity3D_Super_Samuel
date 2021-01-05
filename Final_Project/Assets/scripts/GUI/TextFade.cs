using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextFade : MonoBehaviour {

    public CanvasGroup myCanvasGroup;
    public CanvasGroup myCanvasGroup2;
    public CanvasGroup myCanvasGroup3;
    public float time = 0;
    private bool fadeOut;
    private bool fadein;

    void Start()
    {
        fadeOut = true;
        fadein = true;
        myCanvasGroup.alpha = 1f;
        myCanvasGroup2.alpha = 0f;
    }

    void Update()
    {
        time += Time.deltaTime;
        if (time >= 3)
        {
            if (fadeOut)
            {
                myCanvasGroup.alpha = myCanvasGroup.alpha - Time.deltaTime/5;
                if (myCanvasGroup.alpha <= 0)
                {
                    myCanvasGroup.alpha = 0;
                    fadeOut = false;
                }
            }
            else
            {
                if (fadein)
                {
                    myCanvasGroup2.alpha = myCanvasGroup2.alpha + Time.deltaTime / 3;
                    if (myCanvasGroup2.alpha >= 1)
                    {
                        myCanvasGroup2.alpha = 1;
                        fadein = false;
                    }

                }
                else
                {
                    myCanvasGroup3.alpha = 1;
                }
            
            }
        }
        
    }
}


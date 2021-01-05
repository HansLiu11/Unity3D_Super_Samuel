using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fade : MonoBehaviour {
    public CanvasGroup myCanvasGroup;
    private bool fadein;
    // Use this for initialization
    void Start () {
        fadein = true;
        myCanvasGroup.alpha = 0f;
    }
	
	// Update is called once per frame
	void Update () {
        if (fadein)
        {
            myCanvasGroup.alpha = myCanvasGroup.alpha + Time.deltaTime / 5;
            if (myCanvasGroup.alpha >= 1)
            {
                myCanvasGroup.alpha = 1;
                fadein = false;
            }
        }
    }
}

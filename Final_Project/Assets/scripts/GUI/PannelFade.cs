using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PannelFade : MonoBehaviour {
    public float time = 0f;
	// Use this for initialization
	void Start () {
		GetComponent<CanvasGroup>().alpha = 1;
	}
	
	// Update is called once per frame
	void Update () {
        time += Time.deltaTime/5; 
        if (time >= 1&& Input.anyKeyDown)
        {
            GetComponent<CanvasGroup>().alpha = 0;
            GetComponent<CanvasGroup>().interactable = false;
            GetComponent<CanvasGroup>().blocksRaycasts = false;
        }
        
    }
}

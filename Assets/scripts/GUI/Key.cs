using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour {
    public Texture key;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnGUI()
    {
        
        if(GameData.Church_1 == 96)
            GUI.Label(new Rect(0.01f*Screen.width, 0.9f*Screen.height, 0.01f*Screen.width, 0.01f * Screen.width), key);
        /*
        GUI.Label(new Rect(X+ Size+10, Y, Size, Size), key);
        GUI.Label(new Rect(X + 2*Size+20, Y, Size, Size), key);
        */

    }
}

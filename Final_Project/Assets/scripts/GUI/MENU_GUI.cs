using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class MENU_GUI : MonoBehaviour {
    private string pname = "Enter Your Name";
    // Use this for initialization
    private void Awake()
    {
        
    }
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
    }
    private void OnGUI()
    {

        //Enter
        if (Event.current.Equals(Event.KeyboardEvent("return")))
        {
            if (pname == "Enter Your Name")
                GameData.Names = "Player";
            else
                GameData.Names = pname;
            Debug.Log(GameData.Names);
        }
        pname = GUI.TextField(new Rect(0.43f * Screen.width, 0.6f * Screen.height, 0.1f * Screen.width, 0.05f * Screen.height), pname);
        
    }  
}

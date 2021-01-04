using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class MENU_GUI : MonoBehaviour {
    public int button_X;
    public int button_Y;
    public int button_Heigh;
    public int button_Wide;
    private string pname = "Player";
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
            GameData.Names = pname;
            Debug.Log(GameData.Names);
        }
        pname = GUI.TextField(new Rect(25, Screen.height - 40, 100, 30), pname);
    }  
}

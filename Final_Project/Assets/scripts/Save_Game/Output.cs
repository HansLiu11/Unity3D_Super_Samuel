using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class Output : MonoBehaviour {
    string LoadData;
    Data MyData;
    // Use this for initialization
    void Start () {
        
        LoadData = File.ReadAllText(System.IO.Path.Combine(Application.dataPath, "Top3.json"));
        //把字串轉換成Data物件
        MyData = JsonUtility.FromJson<Data>(LoadData);
    }
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnGUI()
    {
        GUIStyle coinstyle = new GUIStyle();
        coinstyle.normal.textColor = new Color(135, 206, 235);
        coinstyle.fontSize = 45;
        GUI.Label(new Rect(0.15f * Screen.width, 0.33f * Screen.height, 0.2f * Screen.width, 0.2f * Screen.width), "Name\n\n" + MyData.name_1 + "\n\n" + MyData.name_2 + "\n\n" + MyData.name_3, coinstyle);
        GUI.Label(new Rect(0.45f * Screen.width, 0.33f * Screen.height, 0.2f * Screen.width, 0.2f * Screen.width), "Time\n\n" + (MyData.time_1/60)+":"+(MyData.time_1 % 60) + "\n\n" + (MyData.time_2 / 60) + ":" + (MyData.time_2 % 60) + "\n\n" + (MyData.time_3 / 60) + ":" + (MyData.time_3 % 60), coinstyle);
        GUI.Label(new Rect(0.75f * Screen.width, 0.33f * Screen.height, 0.2f * Screen.width, 0.2f * Screen.width), "Coin\n\n" + MyData.Coins_1 + "\n\n" + MyData.Coins_2 + "\n\n" + MyData.Coins_3, coinstyle);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class END : MonoBehaviour {
    // Use this for initialization
    private int count = 0;
	void Start () {

    }
	
	// Update is called once per frame
	void Update () {
        count++;
	}
    private void OnGUI()
    {
        GUIStyle coinstyle = new GUIStyle();
        coinstyle.normal.textColor = new Color(248, 255, 153);
        coinstyle.fontSize = (int)(0.07f * Screen.height);
        if (count > 600)
        {
            GUI.Label(new Rect(0.7f * Screen.width, 0.4f * Screen.height, 0.07f * Screen.height, 0.07f * Screen.height), "Name： " + GameData.Names, coinstyle);
            GUI.Label(new Rect(0.7f * Screen.width, 0.5f * Screen.height, 0.07f * Screen.height, 0.07f * Screen.height), "Life： " + GameData.Lifes, coinstyle);
            GUI.Label(new Rect(0.7f * Screen.width, 0.6f * Screen.height, 0.07f * Screen.height, 0.07f * Screen.height), "Time： " + (GameData.Score / 3600) + ":" + ((GameData.Score / 60) % 60), coinstyle);
            GUI.Label(new Rect(0.7f * Screen.width, 0.7f * Screen.height, 0.07f * Screen.height, 0.07f * Screen.height), "Score： " + (GameData.Coins + 10 * (GameData.Lifes)), coinstyle);
        }
        if (count > 800)
        {
            if (GUI.Button(new Rect(0.9f * Screen.width, 0.9f * Screen.height, 0.08f * Screen.width, 0.08f * Screen.height), "MENU"))
            {
                SceneManager.LoadScene(0);
                GameData.save_here = true;
            }
        }
    }
}

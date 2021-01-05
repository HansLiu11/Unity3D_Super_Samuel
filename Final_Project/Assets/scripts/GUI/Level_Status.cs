using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
public class Level_Status : MonoBehaviour
{
    public Texture img1;
    public Texture img2;
    public Texture img3;
    public Texture KEY;
    //public Player_Mode player;

    // Use this for initialization
    private void Awake()
    {

    }
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnGUI()
    {
        GUIStyle coinstyle = new GUIStyle();
        coinstyle.normal.textColor = new Color(255, 215, 0);
        coinstyle.fontSize = (int)(0.04f*Screen.width);
        GUI.Label(new Rect(0.95f * Screen.width, 0.005f * Screen.height, 200, 50), GameData.Coins.ToString(), coinstyle);
        GUI.Label(new Rect(0.45f * Screen.width, 0.005f * Screen.height, 200, 50), ((GameData.Score) / 3600).ToString() + "：" + (((GameData.Score) / 60) % 60).ToString(), coinstyle);
        for (int i = 0; i <= 9; ++i)
        {
            if (GameData.Lifes > 10)
                GameData.Lifes = 10;
            if (i < GameData.Lifes)
                GUI.Label(new Rect(0.005f * Screen.width + (0.03f * Screen.width * i), 0.005f * Screen.height, 0.03f * Screen.width, 0.03f * Screen.width), img1);
            else
                GUI.Label(new Rect(0.005f * Screen.width + (0.03f * Screen.width * i), 0.005f * Screen.height, 0.03f * Screen.width, 0.03f * Screen.width), img2);
            //Debug.Log("OnGUI" + GameData.Lifes);
        }
        GUI.Label(new Rect(0.90f*Screen.width, 0.005f * Screen.height, 0.04f * Screen.width, 0.04f * Screen.width), img3);

        if (GameData.Church_1 == 96)
        {
            GameData.key_1 = true;
        }
        if (GameData.key_1)
            GUI.Label(new Rect(0.01f * Screen.width, 0.9f * Screen.height, 0.04f * Screen.width, 0.04f * Screen.width), KEY);
        if (GameData.key_2)
            GUI.Label(new Rect(0.06f * Screen.width, 0.9f * Screen.height, 0.04f * Screen.width, 0.04f * Screen.width), KEY);
        if (GameData.key_3)
            GUI.Label(new Rect(0.11f * Screen.width, 0.9f * Screen.height, 0.04f * Screen.width, 0.04f * Screen.width), KEY);
    }
}
[System.Serializable]
public class player
{
    public string player_name;
    public int coin;
    public int life;
    public int score;
}
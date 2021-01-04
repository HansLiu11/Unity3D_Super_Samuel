using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
public class Level_Status : MonoBehaviour {
    public Texture img1;
    public Texture img2;
    public Texture img3;
    //public Player_Mode player;
    public int life_X;
    public int life_Y;
    public int life_Wide = 50;
    public int coin_X = 650;
    public int coin_Y = 0;
    public int coin_Wide = 50;
    public int button_X;
    public int button_Y;
    public int button_Heigh;
    public int button_Wide;
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
        coinstyle.normal.textColor = new Color(255,215,0);
        coinstyle.fontSize = 45;
        GUI.Label(new Rect(coin_X + 70, coin_Y, 200, 50), GameData.Coins.ToString(),coinstyle);

        for (int i = 0; i <= 9; ++i)
        {
            if (i < GameData.Lifes)
                GUI.Label(new Rect(life_X + (life_Wide * i), life_Y, life_Wide, life_Wide), img1);
            else
                GUI.Label(new Rect(life_X + (life_Wide * i), life_Y, life_Wide, life_Wide), img2);
            //Debug.Log("OnGUI" + GameData.Lifes);
        }
        GUI.Label(new Rect(coin_X , coin_Y, coin_Wide, coin_Wide), img3);
        GUI.Label(new Rect(),"Score : "+ GameData.Score);
        if (GUI.Button(new Rect(button_X, button_Y, button_Wide, button_Heigh), "Save"))
        {
            {
                player p = new player();
                p.player_name = "陳彥博";
                p.coin = GameData.Coins;
                p.score = GameData.Score;
                p.life = GameData.Lifes;
                string a = JsonUtility.ToJson(p);
                StreamWriter file = new StreamWriter(System.IO.Path.Combine("Assets/GameJSONData", "Player.json"));
                //StreamWriter file = new StreamWriter(System.IO.Path.Combine(Application.streamingAssetsPath, "Player.json"));
                file.Write(a);
                file.Close();
            }
            //Debug.Log(play.score);
            Debug.Log("Clicked the button with an image");
        }
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
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.IO;
public class Dead_Reload : MonoBehaviour {
    public int SCENE;
    private bool reload = false;
    public Rigidbody play2;
    private int tim = 0;
    private bool re = false;
	// Use this for initialization
	void Start () {
        reload = false;
	}
	
	// Update is called once per frame
	void Update () {
        if (GameData.Lifes <= 0)
        {
            reload = true;
            play2.constraints = RigidbodyConstraints.FreezePosition | RigidbodyConstraints.FreezeRotation;
            re = true;
        }
	}
    private void OnGUI()
    {
        GUIStyle coinstyle = new GUIStyle();
        coinstyle.normal.textColor = new Color(255, 215, 0);
        coinstyle.fontSize = (int)(0.04f * Screen.width);
        if (reload)
        {
            
            if(re)
            {
                if(tim != 0)
                    tim = GameData.Score;
                re = false;
            }
            if (GUI.Button(new Rect(0.45f*Screen.width, 0.45f*Screen.height,0.1f* Screen.width, 0.1f * Screen.height), "ＲＥＰＬＡＹ"))
            {
                GameData.Lifes = 10;
                GameData.key_1 = false;
                GameData.key_2 = false;
                GameData.key_3 = false;
                GameData.Setfloor = 0;
                GameData.Coins = 0;
                {
                    player p = new player();
                    p.player_name = GameData.Names;
                    p.coin = GameData.Coins;
                    p.score = tim;
                    p.life = GameData.Lifes;
                    string a = JsonUtility.ToJson(p);
                    StreamWriter file = new StreamWriter(System.IO.Path.Combine(Application.dataPath, "Player.json"));
                    file.WriteLine(a);
                    file.Close();
                }
                reload = false;
                Scene cur_scene = SceneManager.GetActiveScene();
                SceneManager.LoadScene(SCENE);
            }
           
        }
    }
}

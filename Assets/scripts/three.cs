using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.IO;
public class three : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            {//寫檔案
                player p = new player();
                p.player_name = GameData.Names;
                p.coin = GameData.Coins;
                p.score = GameData.Score;
                p.life = GameData.Lifes;
                string a = JsonUtility.ToJson(p);
                StreamWriter file = new StreamWriter(System.IO.Path.Combine(Application.dataPath, "Player.json"));
                //StreamWriter file = new StreamWriter(System.IO.Path.Combine(Application.streamingAssetsPath, "Player.json"));
                file.WriteLine(a);
                file.Close();
            }
            Scene cur_scene = SceneManager.GetActiveScene();
            SceneManager.LoadScene(6);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.IO;
public class Level2_3_add : MonoBehaviour {
    private bool i = false;
    private Rigidbody rigid;
	// Use this for initialization
	void Start () {
        rigid = GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    void Update()
    {
        if (GameData.key_1 && GameData.key_2 && GameData.key_3)
        {
            i = true;
            
        }
        if (transform.position.y > 500)
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
            SceneManager.LoadScene(4);
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag=="FLY")
        {
            if (i)
            {
                rigid.useGravity = false;
                rigid.AddForce(Vector3.up * 3000);
                rigid.constraints = RigidbodyConstraints.FreezePositionX
                | RigidbodyConstraints.FreezePositionZ
                | RigidbodyConstraints.FreezeRotation;
                GameData.Church_1 -= 1;
                i = false;
                GameData.key_1 = false;
                GameData.key_2 = false;
                GameData.key_3 = false;
            }
        }

    }
}

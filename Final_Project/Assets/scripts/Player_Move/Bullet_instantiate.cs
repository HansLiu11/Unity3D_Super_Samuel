using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet_instantiate : MonoBehaviour {
    public Transform bullet;
    public Transform play;
    //public Mathf Math;
    // Use this for initialization
    void Start () {
        
    }
	
	// Update is called once per frame
	void Update () {
        //Debug.Log("BulletNum:" + GameData.BulletNum);
        if (Input.GetMouseButtonDown(0) )//&& GameData.BulletNum<5)
        {
            
            GameData.BulletNum++;
            Transform B = Instantiate(bullet);
            //B.SetParent(play);
            B.localPosition = play.localPosition+new Vector3(0,1f,0);
            B.localScale = new Vector3(1, 1, 1);

            //B.localRotation = play.localRotation;
        }

    }
}

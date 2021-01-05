using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Dead_Blood : Blood_Bar{
    public Transform cam;
    public GameObject game_object;
    public int currentBlood;
    public int MaxBlood;
    public int Minus_blood;
    public int set;
	// Use this for initialization
	void Start () {
        currentBlood = MaxBlood;
        SetMaxHealth(currentBlood,MaxBlood);
	}
	
	// Update is called once per frame
	void Update () {
        SetHealth(currentBlood);
        if (currentBlood < 0)
        {
            Destroy(game_object);
            GameData.Setfloor=set;
            Scene cur_scene = SceneManager.GetActiveScene();
            if (cur_scene.name =="Level_2")
            {
                GameData.key_2 = true;
            }
        }
	}
    private void LateUpdate()
    {
        transform.LookAt(transform.position + cam.forward);
    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag =="Player")
        {
            currentBlood = currentBlood - Minus_blood;
            
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Bullet")
        {
            currentBlood = currentBlood - Minus_blood;
            Destroy(other.gameObject);
            //SetHealth(currentBlood);
        }
    }
}

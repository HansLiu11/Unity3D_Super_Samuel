using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dead_Blood : Blood_Bar{
    public Transform cam;
    public GameObject game_object;
    public int currentBlood;
    public int MaxBlood;
    public int Minus_blood;
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
        }
	}
    private void LateUpdate()
    {
        transform.LookAt(transform.position + cam.forward);
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Bullet")
        {
            currentBlood = currentBlood - Minus_blood;
            //SetHealth(currentBlood);
        }
    }
}

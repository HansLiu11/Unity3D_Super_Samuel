using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class brick_effect : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.localPosition += new Vector3(1, 0, 0) * GameData.mspeed;
        if (GameData.setact == 1)
        {
            this.gameObject.SetActive(true);
            Debug.Log("Samuel");
        }
	}
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag=="Bullet")
        {
            this.gameObject.SetActive(false);
        }
        if(other.gameObject.tag=="Player")
        {
            GameData.Lifes--;
        }
    }
}

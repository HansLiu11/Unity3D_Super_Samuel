using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bomb_effect : MonoBehaviour {
    public Transform astro;
    public float range;
    int count=0;
    
    float diff;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        count++;
        if (count == 10095)
        {
            diff = (astro.position.x - transform.position.x) * (astro.position.x - transform.position.x) + (astro.position.z - transform.position.z) * (astro.position.z - transform.position.z);
            Debug.Log("Diff:" + diff);
            if (diff < range || diff > -range)
            {
                GameData.Lifes -= 2;
            }
        }
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player" || collision.gameObject.tag == "Bullet")
        {  
            count = 10000;
        }
        
    }
}

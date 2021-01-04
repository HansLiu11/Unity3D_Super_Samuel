using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube1_effect : MonoBehaviour {
    
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            
            GameData.Lifes -= 1;
            Debug.Log(GameData.Lifes);
            
        }
    }
}

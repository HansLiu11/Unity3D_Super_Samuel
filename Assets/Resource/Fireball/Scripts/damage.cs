using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class damage : MonoBehaviour {
    private ParticleSystem ps;
	// Use this for initialization
	void Start () {
        ps = GetComponent<ParticleSystem>();
        this.transform.parent = null;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnParticleCollision(GameObject other)
    {
        if (other.tag == "Player")
        {
            GameData.Lifes -= 1;
        }
    }
}

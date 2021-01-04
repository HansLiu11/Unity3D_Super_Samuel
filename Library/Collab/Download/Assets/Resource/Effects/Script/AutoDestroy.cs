using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoDestroy : MonoBehaviour {

    public float timer = 3.0f;
	// Use this for initialization
	void Start () {
        Destroy(this.gameObject, timer);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

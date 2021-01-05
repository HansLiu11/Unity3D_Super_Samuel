using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyFB : MonoBehaviour {

    private ParticleSystem fb; 
	// Use this for initialization
	void Start () {
        fb = this.gameObject.GetComponent<ParticleSystem>();
	}
	
	// Update is called once per frame
	void Update () {
        if (!fb.IsAlive())   //判斷粒子是否存在
        {
            Destroy(this.gameObject);
        }
	}
}

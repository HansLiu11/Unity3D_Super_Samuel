using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class monster_instantiate : MonoBehaviour {
    public Transform monster1;
	// Use this for initialization
	void Start () {
        int rd = 20;
        Transform c = Instantiate(monster1);
        int x = Random.Range(0, rd);
        int z = Random.Range(0, rd);
        c.position = new Vector3(x, 3, z);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

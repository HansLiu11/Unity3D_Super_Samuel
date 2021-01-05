using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lava_move : MonoBehaviour {
    public Transform lava;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (lava.localPosition.y < 55)
        {
            lava.position += new Vector3(0, 0.6f, 0) * Time.deltaTime;
        }
	}
}

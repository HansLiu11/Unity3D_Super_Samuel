using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coin_instantiate : MonoBehaviour {
    public Transform coin;
    Vector3 inpos;
    int x, z;
	// Use this for initialization
	void Start () {
		for(int i=1;i<100;i++)
        {
            x=i % 10 ;
            z=i / 10 ;
            Transform c = Instantiate(coin);
            inpos = new Vector3(21.8f + x * 1.75f, 62, 162.1f + 1.75f * z);
            c.localPosition = inpos;
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

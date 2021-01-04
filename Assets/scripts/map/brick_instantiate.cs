using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class brick_instantiate : MonoBehaviour {
    int x, z,tf;
    public float gap;
    public Transform brick;
    Vector3 inpos;
	// Use this for initialization
	void Start () {
		for(int i=1;i<200;i++)
        {
            x = i % 40;
            z = i / 40;
            tf= Random.Range(0, 4);
            if (tf == 1)
            {
                Transform b = Instantiate(brick);
                //b.SetParent(brick);
                //b.parent = brick;
                inpos = new Vector3(-27, 61+gap*z, 93 + gap * x);
                b.localPosition = inpos;
            }
        }
        for (int i = 0; i < 200; i++)
        {
            x = i % 40;
            z = i / 40;
            tf = Random.Range(0, 4);
            if (tf == 1)
            {
                Transform b = Instantiate(brick);
                //b.SetParent(brick);
                //b.parent = brick;
                inpos = new Vector3(-24, 61 + gap * z, 93 + gap * x);
                b.localPosition = inpos;
            }
        }
        for (int i = 0; i < 200; i++)
        {
            x = i % 40;
            z = i / 40;
            tf = Random.Range(0, 4);
            if (tf == 1)
            {
                Transform b = Instantiate(brick);
                //b.SetParent(brick);
                //b.parent = brick;
                inpos = new Vector3(-21, 61 + gap * z, 93 + gap * x);
                b.localPosition = inpos;
            }
        }
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}

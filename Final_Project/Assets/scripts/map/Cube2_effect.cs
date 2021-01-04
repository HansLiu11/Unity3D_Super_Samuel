using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube2_effect : MonoBehaviour {
    bool deter = false;
    // Use this for initialization
    void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
        if(deter)
        {
            transform.localScale -= new Vector3(0.01f,0,0.01f);
            if (transform.localScale.x <0 || transform.localScale.z <0)
            {
                Destroy(this.gameObject);
            }
        }
	}
    private void OnCollisionEnter(Collision collision)
    {
        deter = true;
    }
}

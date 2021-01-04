using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube_effect : MonoBehaviour {
    MeshRenderer meshrenderer;
    // Use this for initialization
    void Start () {
        meshrenderer = GetComponent<MeshRenderer>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Stylized Astronaut")
        {
            meshrenderer.material.color = new Color(127, 255, 0);
            Debug.Log("change");
        }
    }

}

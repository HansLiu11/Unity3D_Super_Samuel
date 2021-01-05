using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube_effect : MonoBehaviour {
    MeshRenderer meshrenderer;
    public Transform cube;
    float index;
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
            index = (cube.position.x / 3.5f) * 30 + (cube.position.z / 3.5f);
            GameData.gamemap[(int)index] = 11;
            meshrenderer.material.color = new Color(127, 255, 0);
            Debug.Log("change");
            Debug.Log(index);
        }
    }

}

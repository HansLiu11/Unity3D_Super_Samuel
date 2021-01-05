using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using System.IO;
public class Retry1 : MonoBehaviour {
    Rigidbody rb;
    player MyData;
    string LoadData;
    // Use this for initialization
    void Start () {
        
    }
	
	// Update is called once per frame
	void Update () {
        rb = GetComponent<Rigidbody>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Dead")
        {
            /*rb.constraints &= ~RigidbodyConstraints.FreezeRotationX;
            rb.constraints &= ~RigidbodyConstraints.FreezeRotationY;
            rb.constraints &= ~RigidbodyConstraints.FreezeRotationZ;*/
            rb.constraints = RigidbodyConstraints.None;
            rb.AddTorque(new Vector3(1, 1, 1) * 5);
            GameData.Lifes = 0;
        }

    }
}

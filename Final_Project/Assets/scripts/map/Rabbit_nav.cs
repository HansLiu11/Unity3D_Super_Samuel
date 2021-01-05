using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rabbit_nav : MonoBehaviour {
    public Transform astro;
    public float speed;
    Vector3 dire;
    Rigidbody rb;
    // Use this for initialization
    void Start () {
        rb = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
        dire = astro.localPosition - transform.localPosition;
        rb.AddForce(dire * speed);
        if(transform.localPosition.y<12)
        {
            GameData.Setfloor = 2;
            Destroy(this);
        }
        transform.LookAt(astro.localPosition);
	}
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag=="Player")
        {
            rb.AddForce(transform.forward * -1.5f);
        }
    }
}

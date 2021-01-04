using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class three_enter : MonoBehaviour {

    // Use this for initialization
    public Rigidbody rigid;
    private bool ia = false;
    private void Awake()
    {
    }
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (ia)
        {
            rigid.useGravity = false;
            rigid.AddForce(Vector3.up * 3000);
            rigid.constraints = RigidbodyConstraints.FreezePositionX
            | RigidbodyConstraints.FreezePositionZ
            | RigidbodyConstraints.FreezeRotation;
            ia = false;
        }

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "FLYY")
        {
            ia = true;
        }
    }
}

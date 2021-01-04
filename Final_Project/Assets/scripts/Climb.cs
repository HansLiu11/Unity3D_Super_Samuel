using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Climb : MonoBehaviour {
    public float range = 1f;
    public float climbspeed = 5f;
    public float sticktowallforce = 5f;
    private Rigidbody rigid;
    // Start is called before the first frame update
    void Start()
    {
        rigid = GetComponent<Rigidbody>();
    }
    // Update is called once per frame
    void Update()
    {
      
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Airdoor")
        {
            rigid.constraints = RigidbodyConstraints.FreezeRotation;
            rigid.useGravity = true;
        }
        if (other.tag == "ladder")
        {
            rigid.constraints = RigidbodyConstraints.FreezePositionX
                | RigidbodyConstraints.FreezePositionZ
                | RigidbodyConstraints.FreezeRotation;
            rigid.useGravity = false;
            
            if (Input.GetKey(KeyCode.C)&& Input.GetKey(KeyCode.W))
            {
                //transform.position += transform.forward * Time.deltaTime * sticktowallforce;
                transform.position += transform.up * Time.deltaTime * climbspeed;
            }
            if (Input.GetKey(KeyCode.C) && Input.GetKey(KeyCode.S))
            {
                //transform.position += transform.forward * Time.deltaTime * sticktowallforce;
                transform.position -= transform.up * Time.deltaTime * climbspeed;
            }
        }
    }
}

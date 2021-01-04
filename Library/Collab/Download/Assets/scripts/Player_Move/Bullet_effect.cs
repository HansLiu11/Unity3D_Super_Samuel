using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet_effect : MonoBehaviour {
    Rigidbody rb;
    public Transform bullet;
    public float speed;
    // Use this for initialization
    void Start () {
        rb = GetComponent<Rigidbody>();
        rb.AddForce(GameData.Bulletdic * speed);       
    }
	
	// Update is called once per frame
	void Update () {
        if(bullet.localPosition.x* bullet.localPosition.x+ bullet.localPosition.y* bullet.localPosition.y+ bullet.localPosition.z*bullet.localPosition.z>2500)
        {
            GameData.BulletNum--;
            Destroy(bullet.gameObject);
            Debug.Log("Destroy");
        }
	}

    /*private void OnTriggerEnter(Collider other)
    {

        if(other.gameObject.tag=="Player")
        {

        }
        else
        {
            Destroy(this);
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {

        }
        else
        {
            Destroy(this);
        }
    }*/
}

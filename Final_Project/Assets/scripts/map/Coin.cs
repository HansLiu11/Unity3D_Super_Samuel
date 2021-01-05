using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(Rigidbody))]

public class Coin : MonoBehaviour {
    Rigidbody rb;
    private Vector3 torquedirection = new Vector3(0, 1, 0);
    [SerializeField] float torqueforce;
    // Use this for initialization
    void Start () {
        rb = GetComponent<Rigidbody>();
    }
	
	// Update is called once per frame
	void Update () {
        rb.AddTorque(torquedirection * torqueforce);
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Destroy(this.gameObject);
            Debug.Log("fvbdfb");
            GameData.Coins += 1;
            Debug.Log(GameData.Coins);
            Debug.Log("Here");
            if (GameData.Church_1_in)
                GameData.Church_1++;
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Destroy(this.gameObject);
            Debug.Log("fvbdfb");
            GameData.Coins += 1;
            Debug.Log(GameData.Coins);
            Debug.Log("Here");
            if (GameData.Church_1_in)
                GameData.Church_1++;
        }
    }
}

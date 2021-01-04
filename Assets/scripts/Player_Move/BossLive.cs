using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossLive : MonoBehaviour {
    public GameObject bull;
    public GameObject brick;
    public GameObject light;
    public GameObject light2;
    public GameObject brick_ins;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            bull.SetActive(true);
            brick.SetActive(true);
            light.SetActive(false);
            brick_ins.SetActive(true);
            light2.SetActive(true);
        }
    }
}

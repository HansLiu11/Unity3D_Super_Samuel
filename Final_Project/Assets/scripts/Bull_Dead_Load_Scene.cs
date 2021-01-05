using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bull_Dead_Load_Scene : MonoBehaviour
{
    public int count;
    public GameObject g;

	// Use this for initialization
	void Start () {
        count = 0;
	}
	
	// Update is called once per frame
	void Update () {
		if(count == 99)
        {
            g.SetActive(true);
        }
	}
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Bullet")
        {
            count++;
            Debug.Log("bULL");
        }
    }
}

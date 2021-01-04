using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Release : MonoBehaviour {
    public GameObject target;
    public Transform Point;
    private Animation ani;
    private float PauseTime = 0;
    public float interval = 1f;
    // Use this for initialization
    void Start () {
        //ani = GetComponents<Animation>();
	}
	
	// Update is called once per frame
	void Update () {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            GetComponents<Animation>()[0].Play();
            GameObject effect = Instantiate(target, Point);
            PauseTime = 0;
        }
       
    }
}

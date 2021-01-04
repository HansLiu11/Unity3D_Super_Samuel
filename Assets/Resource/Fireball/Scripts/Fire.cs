using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire : MonoBehaviour {
    public GameObject mon;
    public GameObject target;
    public Transform Point;
    private Animator ani;
    private float PauseTime = 0;
    public float interval = 1f;
	// Use this for initialization
	void Start () {
        ani = mon.GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
        PauseTime += Time.deltaTime;
        if(ani.GetCurrentAnimatorStateInfo(0).IsName("Attack")&& PauseTime > interval)
        {
            GameObject bullet = Instantiate(target,Point);
            PauseTime = 0;
        }
	}
}

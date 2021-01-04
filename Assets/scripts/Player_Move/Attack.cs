using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : MonoBehaviour {
    Rigidbody rb;
    Animator animator;
    
    // Use this for initialization
    void Start () {
        rb = GetComponent<Rigidbody>();
        animator = GetComponent<Animator>();
    }
	
	// Update is called once per frame
	void Update () {

        if (Input.GetMouseButtonDown(0))
        {
            
            Debug.Log("ATTACK");
            //GameData.Bulletdic = Camera.main.ScreenToWorldPoint(Input.mousePosition)-bullet.localPosition;
            GameData.Bulletdic = transform.forward;
            animator.SetFloat("attack", 2f);
        }
        else
        {
            animator.SetFloat("attack", 0f);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(Animator))]

public class Bull_effect : MonoBehaviour {
    //Animation animation;
    public float speed;
    public Transform brick;
    public GameObject floor1;
    public GameObject floor2;
    int count=0;
    Animator animator;
	// Use this for initialization
	void Start () {
        //animation = GetComponent<Animation>();
        animator = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
        Debug.Log("Mspeed = " + GameData.mspeed);
        count++;
        if(count>=1&&count<300)
        {
            animator.SetInteger("state", 0);
        }
        if(count >= 300 && count < 360)
        {
            animator.SetInteger("state", 1);
            GameData.mspeed = 0;
        }
        if (count >= 360 && count < 660)
        {
            animator.SetInteger("state", 0);
            GameData.mspeed = speed;
        }
        if (count >= 660 && count < 720)
        {
            animator.SetInteger("state", 2);
            GameData.mspeed = 0;
            if (count < 700) GameData.setact = 1;
            else
            {
                GameData.setact = 0;
            }
        }
        if (count >= 720 && count < 1020)
        {
            animator.SetInteger("state", 0);
            GameData.mspeed = -speed;
        }
        if (count >= 1020 && count < 1080)
        {
            animator.SetInteger("state", 3);
            GameData.mspeed = 0;
            if (count < 1050) GameData.setact = 1;
            else
            {
                GameData.setact = 0;
            }
        }
        if(count==1080)
        {
            count = 0;
        }


    }
    private void OnCollisionEnter(Collision collision)
    {
        floor1.SetActive(false);
        floor2.SetActive(true);
        
    }
    /*public void AnimationToIdle()//行走動作

    {

        animation.Play("idle");

        //這個就是使動作開始播放的程式碼，使用的屬性是animation的Play屬性
    }
    public void AnimationToattack1()
    {
        animation.Play("attack_01");
    }
    public void AnimationToattack2()
    {
        animation.Play("attack_02");
    }
    public void AnimationToattack3()
    {
        animation.Play("attack_03");
    }*/
}

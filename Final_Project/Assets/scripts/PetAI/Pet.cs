using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Pet : MonoBehaviour {

    Animator ani;
    NavMeshAgent NMA;         //導航控制組件
    private GameObject target;//玩家對象
    public Vector3 offset;
    float distance;           //玩家和寵物之間的距離
    int tarstate;
    int nowstate;             //當前寵物所處的狀態
    float anitime;            //從移動改變為停止的動畫改變的時刻
    //移動的時間
    float movetime;
    // Use this for initialization
    void Start () {
        target = GameObject.FindGameObjectWithTag("Player");
        NMA = gameObject.GetComponent<NavMeshAgent>();
        tarstate = target.GetComponent<Animator>().GetInteger("AnimationPar");
        nowstate = 0;
        anitime = 0;
        ani = gameObject.GetComponent<Animator>();
    }
	
	// Update is called once per frame
	void Update () {
        tarstate = target.GetComponent<Animator>().GetInteger("AnimationPar");//player狀態
        Debug.Log(tarstate);
        transform.rotation = target.transform.rotation;
        //距離改變函數
        distancechange();
        //狀態改變函數
        statechange();
    }
    void distancechange()
    {
        
        if (tarstate == 1) //移動狀態
        {
            ani.SetBool("stand", true);
            nowstate = 2;
        }
        else               //停止狀態
        {
            ani.SetBool("stand", false);
            nowstate = 0;
        }
    }
    void statechange()
    {
        if (nowstate == 0)
        {
            ani.SetFloat("anitime", anitime);
            NMA.isStopped = true;     //導航停止
            anitime += Time.deltaTime;//停留時間自增
                
        }
        else if(nowstate == 1)
        {
            
        }
        else if (nowstate == 2)
        {
            NMA.isStopped = false;//導航恢復
            NMA.destination = target.transform.position;//導航到玩家位置
            if (NMA.remainingDistance > 8)
            {
                NMA.acceleration = 12;
                ani.SetFloat("speed", 5);
            }
            else if (NMA.remainingDistance < 3)
            {
                NMA.isStopped = true;
                ani.SetTrigger("stop");
            }
            else
            {
                ani.SetFloat("speed", 3);
                NMA.acceleration = 8;
            }
            anitime = 0;
        }
    }
}

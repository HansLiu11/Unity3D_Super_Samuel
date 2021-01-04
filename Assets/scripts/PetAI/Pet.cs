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
        distance = Vector3.Distance(transform.position, target.transform.position);
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
        else if(distance < 3)
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
            Debug.Log("state 0");
        }
        else if(nowstate == 1)
        {
            
        }
        else if (nowstate == 2)
        {
            Debug.Log("state 2");
            NMA.isStopped = false;//導航恢復
            NMA.destination = target.transform.position + new Vector3(-1, 0, 1);//導航到玩家位置附近
            Debug.DrawLine(transform.position, NMA.destination, Color.red);//寵物和玩家之間畫一條紅線
            Vector3 newpos = target.transform.position + new Vector3(-1, 0, 1);
            transform.position = Vector3.Lerp(transform.position, newpos, Time.deltaTime);
            if (Input.GetKey(KeyCode.LeftShift))
            {
                NMA.acceleration = 12;
                ani.SetFloat("speed", 5);
            }
            else if (NMA.remainingDistance < 3)
            {
                NMA.isStopped = true;
                ani.SetFloat("speed", 0);
                ani.SetTrigger("stop");
            }
            else if(NMA.remainingDistance > 3 && NMA.remainingDistance > 5)
            {
                ani.SetFloat("speed", 3);
                NMA.acceleration = 8;
            }
            anitime = 0;
        }
    }
}

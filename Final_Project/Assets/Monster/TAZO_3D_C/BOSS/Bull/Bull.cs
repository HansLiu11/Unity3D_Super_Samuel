using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Bull : MonoBehaviour {

    // Use this for initialization
    Animator ani;//動畫控制組件
    NavMeshAgent NMA;//導航控制組件
    Vector3 nextpos;
    private GameObject target;//玩家對象
    float distance;//玩家和敵人之間的距離
    int nowstate;//當前敵人所處的狀態
    float speed = 0;
    bool isChangestate;//控制能否改變狀態
    float attacktime = 0;//定義攻擊時間
    //隨機到的兩個數
    float x;
    float z;
    //移動的時間
    float movetime;
    void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player");
        
        //獲取動畫組件
        ani = gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame

    void Update()
    {
        Vector3 targetPos = target.transform.position;
        targetPos.y = transform.position.y;
        transform.LookAt(targetPos);//敵人看向玩家
        
        attacktime += Time.deltaTime;//攻擊時間自增
        if (attacktime < 5)//攻擊時間小於10的時候
        {
            nowstate = 0;
        }
        else if (attacktime >= 5 && attacktime <= 10)//攻擊時間大於10小於20
        {
            nowstate = 1;
        }
        else if (attacktime >= 10 && attacktime <= 15)
        {
            nowstate = 2;
        }
        else //攻擊超過30秒
        {
            attacktime = 0;
        }
        //調用狀態改變函數
        statechange();
    }
    /// <summary>
    /// 狀態改變函數
    /// </summary>
    void statechange()
    {
        //Debug.DrawLine(transform.position, target.transform.position, Color.red);//從當前位置到下一個點之間畫一條紅線（紅線在Scene場景中可見）
        if (nowstate == 0)//如果狀態為0
        {
            if (!ani.GetCurrentAnimatorStateInfo(0).IsName("attack_01"))
                ani.SetBool("attack_01", true);//播放攻擊1動畫
        }
        else if (nowstate == 1)//如果狀態為1
        {
            ani.SetBool("attack_01", false);
            if (!ani.GetCurrentAnimatorStateInfo(0).IsName("attack_02"))
                ani.SetBool("attack_02", true); ;//播放攻擊2動畫
        }
        else if (nowstate == 2)//如果狀態為2
        {
            ani.SetBool("attack_02", false);
            if (!ani.GetCurrentAnimatorStateInfo(0).IsName("attack_03"))
                ani.SetBool("attack_03", true);//播放攻擊3動畫
        }
    }
    /*private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            GameData.Lifes -= 1;
            Debug.Log("collide");
            //Debug.Log(GameData.Lifes);
        }
    }*/
}

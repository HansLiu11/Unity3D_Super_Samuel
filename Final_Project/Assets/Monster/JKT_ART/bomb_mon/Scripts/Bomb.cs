using UnityEngine;
using UnityEngine.AI;

public class Bomb : MonoBehaviour {
    public Transform astro;
    Animator ani;//動畫控制組件
    NavMeshAgent NMA;//導航控制組件
    Vector3 nextpos;
    Rigidbody rb;
    int count;
    private GameObject target;//玩家對象
    float distance;//玩家和敵人之間的距離
    int nowstate;//當前敵人所處的狀態
    bool isRandom;//能否隨機一個坐標點
    float stoptime,time;//從移動改變為停止的狀態改變的時刻
    bool isChangestate,collide;//控制能否改變狀態
    //隨機到的兩個數
    float x;
    float z;
    //移動的時間
    float movetime;
    void Start()
    {
        rb = GameObject.FindGameObjectWithTag("Player").GetComponent<Rigidbody>();
        target = GameObject.FindGameObjectWithTag("Player");
        NMA = gameObject.GetComponent<NavMeshAgent>();//獲取導航組件
        //敵人當前所處狀態為0（發呆動畫、停止不動）
        nowstate = 0;
        //可以隨機一個數
        isRandom = true;
        //停留時間記為0
        stoptime = 0;
        //可以改變狀態
        isChangestate = true;
        //獲取動畫組件
        ani = gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame

    void Update()
    {
        count++;
        //玩家和敵人之間的距離，實時更新
        distance = Vector3.Distance(transform.position, target.transform.position);
        //調用距離改變函數
        distancechange();
        //調用狀態改變函數
        statechange();
        if (collide)
            time += Time.deltaTime;
        AnimatorStateInfo info = ani.GetCurrentAnimatorStateInfo(0);
        if (info.IsName("over") && time >= 1f)
        {
            GameData.dienum++;
            Debug.Log("GameData.dienum = " + GameData.dienum);
            Destroy(this.gameObject);
        }
    }
    void distancechange()
    {
        if (distance <= 10)//如果玩家和敵人之間距離小於10
        {
            isChangestate = true;//可以改變狀態
            nowstate = 2;//敵人狀態為追趕、攻擊玩家
        }
        else  //如果距離大於10
        {
            if (isChangestate == true)//如果可以改變狀態
            {
                nowstate = 0;//狀態改變為自動巡邏的發呆狀態（播放發呆動畫）
                stoptime = 0;//記下狀態改變的時刻
                isChangestate = false;//狀態不可以改變了
            }
        }

    }
    /// <summary>
    /// 狀態改變函數
    /// </summary>
    void statechange()
    {
        if (nowstate == 0)//如果狀態為0
        {
            ani.SetBool("move", false);//播放發呆動畫
            NMA.isStopped = true;//導航停止
            stoptime += Time.deltaTime;//停留時間自增
            isRandom = true;//可以隨機數
            if (stoptime >= 2)//如果停留了2秒
            {
                nowstate = 1;//狀態變為1
            }
        }
        else if (nowstate == 1)//如果狀態為1
        {
            NMA.isStopped = false;//導航恢復
            if (isRandom == true)//如果可以隨機數
            {
                //隨機兩個點（地形范圍內）
                x = Random.Range(-10, 10);
                z = Random.Range(-10, 10);
                nextpos = new Vector3(transform.position.x + x, transform.position.y, transform.position.z + z);
                isRandom = false;//只允許隨機兩個點
            }
            //下一個坐標點為隨機到的點
            ani.SetBool("move", true);//播放走路動畫
            NMA.destination = nextpos; //導航到下一個點          
            //Debug.DrawLine(transform.position, nextpos, Color.red);//從當前位置到下一個點之間畫一條紅線（紅線在Scene場景中可見）
            if (NMA.remainingDistance <= 0.1f)//敵人和下一個點之間的距離小於0.1
            {
                nowstate = 0;//狀態變為0
                stoptime = 0;//停留時間置為0
            }
        }
        else if (nowstate == 2)//如果狀態為2
        {
            NMA.destination = target.transform.position;//導航到玩家位置
            if (NMA.remainingDistance > 2.5f)//如果和玩家距離大於1
            {
                NMA.isStopped = false;
                ani.SetBool("move", true);//播放跑動畫
            }
            else if (NMA.remainingDistance <= 2.5f)//如果和玩家之間距離小於1
            {
                NMA.isStopped = true;//導航停止
                Vector3 targetPos = target.transform.position;
                targetPos.y = transform.position.y;
                transform.LookAt(targetPos);//敵人看向玩家
                //Debug.Log("attack"); 
            }
            //Debug.DrawLine(transform.position, target.transform.position, Color.red);//敵人和玩家之間畫一條紅線
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player" || collision.gameObject.tag == "Bullet")
        {
            AnimatorStateInfo info = ani.GetCurrentAnimatorStateInfo(0);
            ani.SetTrigger("attack");//播放攻擊1動畫
            
            collide = true;
            time = 0;
        }
    }
    private void OnCollisionStay(Collision col)
    {
        if (col.gameObject.tag == "Player")
        {
            AnimatorStateInfo info = ani.GetCurrentAnimatorStateInfo(0);
            if (info.IsName("over"))
            {
                Debug.Log("bomb");
                rb.AddForce(Vector3.forward * 10, ForceMode.Impulse);
                GameData.Lifes -= 2;
                Destroy(this.gameObject);
                
            }
        }
    }
}

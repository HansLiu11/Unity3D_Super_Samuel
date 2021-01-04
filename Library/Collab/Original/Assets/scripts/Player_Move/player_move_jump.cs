using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class player_move_jump : MonoBehaviour {
    private float speed;
    private Vector3 moveDirection = Vector3.zero;
    [SerializeField] float rotate_speed;
    private Vector3 jumpdirection = new Vector3(0, 1, 0);
    [SerializeField] float jumpforce;
    Rigidbody rb;
    Animator animator;
    private int a = 0;
    private Vector3 maindirection;
    public GameObject monstor2;
    public GameObject monstor3;
    public GameObject monstor41;
    public GameObject monstor42;
    public GameObject monstor43;
    public GameObject monstor44;
    public int button_X;
    public int button_Y;
    public int button_Heigh;
    public int button_Wide;
    int one = 0;
    // Use this for initialization
    private void Awake()
    {
    }
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        moveDirection = new Vector3(h, 0, v);
        if(Input.GetKey(KeyCode.LeftShift))
            speed = 4;
        else
            speed = 2.5f;
        if (Input.GetKey(KeyCode.W))
        {
            maindirection = speed * Time.deltaTime * transform.forward;
            rb.MovePosition(rb.position + maindirection * speed);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.RotateAround(transform.position, new Vector3(0, -1, 0), Time.deltaTime * rotate_speed);
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            Vector3 opDirection = new Vector3(0f, -180f, 0f);
            transform.Rotate(opDirection);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.RotateAround(transform.position, new Vector3(0, 1, 0), Time.deltaTime * rotate_speed);
        }
        
        if (Input.GetKeyDown(KeyCode.Space) && a < 1)
        {
            rb.AddForce(jumpdirection * jumpforce);
            a += 2;
        }

        if (Input.GetKey("w") || Input.GetKeyDown("s") || Input.GetKey("a") || Input.GetKey("d"))
            animator.SetInteger("AnimationPar", 1);
        else
            animator.SetInteger("AnimationPar", 0);


        if (Input.GetKeyDown(KeyCode.I))
        {
            GameData.Setfloor += 1;
        }
        if(GameData.dienum==4)
        {
            GameData.Setfloor = 4;
        }
    }
    private void OnCollisionStay(Collision col)
    {
        if (col.gameObject.tag == "ground")
        {
            a = 0;
            if(col.gameObject.name== "big_module_01_02_floorb")
            {
                monstor2.SetActive(true);
            }
            if (col.gameObject.name == "big_module_01_02_floorc")
            {
                monstor3.SetActive(true);
            }
            if (col.gameObject.tag == "Rabbit")
            {
                rb.AddForce(transform.forward * -3);
            }
            if (col.gameObject.name == "big_module_01_02_floord"&&one<1)
            {
                monstor41.SetActive(true);
                monstor42.SetActive(true);
                monstor43.SetActive(true);
                monstor44.SetActive(true);
                one++;
            }
        }
        if (col.gameObject.tag == "monster")
        {
        }
    }
    

}

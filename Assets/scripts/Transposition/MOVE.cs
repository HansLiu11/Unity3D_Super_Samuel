using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class MOVE : MonoBehaviour
{
    public float Bias_x;
    public float Bias_y;
    public float Bias_z;
    private bool castle_is_enter = false;
    private bool inside = false;
    public GameObject go;
    public GameObject point;
    // Use this for initialization
    void Start()
    {
        if (Bias_x < 0)
            Bias_x = 0;
        if (Bias_y < 0)
            Bias_y = 0;
        if (Bias_z < 0)
            Bias_z = 0;

    }

    // Update is called once per frame
    void Update()
    {
        if (inside)
        {
            if (Input.GetKeyDown(KeyCode.O))
            {
                inside = false;
                go.transform.localPosition = new Vector3(point.transform.position.x + Bias_x, point.transform.position.y + Bias_y, point.transform.position.z + Bias_z);
                GameData.Church_1_in = true;
            }
        }
    }
    private void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            inside = true;
        }
    }
    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            inside = false;
        }
    }

    private void OnGUI()
    {
        GUIStyle style = new GUIStyle();
        style.normal.textColor = new Color(255, 255, 255);
        style.fontSize = 45;
        if (inside)
        {
            GUI.Label(new Rect(0.45f*Screen.width, 0.2f*Screen.height, 100, 100), "按 O 進入", style);
        }
    }
}

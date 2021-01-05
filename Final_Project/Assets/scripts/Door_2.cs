using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door_2 : MonoBehaviour {
    private bool   inter = false;
    private bool a;
    public GameObject go;
    public GameObject point;
    public float Bias_x;
    public float Bias_y;
    public float Bias_z;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (a)
        {
            if (Input.GetKeyDown(KeyCode.O)) {
                inter = false;
                a = false;
                go.transform.localPosition = new Vector3(point.transform.position.x + Bias_x, point.transform.position.y + Bias_y, point.transform.position.z + Bias_z);
            }
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
            inter = true;
    }
    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
            inter = false;
    }
    private void OnGUI()
    {
        GUIStyle style = new GUIStyle();
        style.normal.textColor = new Color(255, 255, 255);
        style.fontSize = 45;
        if (inter)
        {
            if (!GameData.key_1)
                GUI.Label(new Rect(0.45f * Screen.width, 0.2f * Screen.height, 100, 100), "請先找出鑰匙\n Hint:教堂", style);
            else
            {
                GUI.Label(new Rect(0.45f * Screen.width, 0.2f * Screen.height, 100, 100), "按 O 進入", style);
                a = true;
            }
        }
    }
}


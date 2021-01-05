using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stage1_effect : MonoBehaviour {
    public GameObject stage1;
    public GameObject stage2;
    public GameObject stage3;
    public GameObject stage4;
    // Use this for initialization
    void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
        //Debug.Log(GameData.Setfloor);
        if (GameData.Setfloor >= 1)
        {
            stage1.SetActive(true);
        }
        if (GameData.Setfloor >= 2)
        {
            stage2.SetActive(true);
        }
        if (GameData.Setfloor >= 3)
        {
            stage3.SetActive(true);
        }
        if (GameData.Setfloor >= 4)
        {
            stage4.SetActive(true);
        }
        

    }
}

using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class Coin_Level_1_Create : MonoBehaviour {
    public Transform coin;
    public Transform insta;
    Vector3 inpos;
    int[,] Co = new int[30, 30];
    int x, z;
    // Use this for initialization
    private void Awake()
    {
        for (int i = 0;i<900;++i)
        {
                Co[i / 30,i % 30] = Random.Range(0, 8);
        }
    }
    void Start()
    {
        
        for (int i = 1; i < 900; i++)
        {
            if (Co[i / 30, i % 30] == 0)
            {
                x = i % 30;
                z = i / 30;
                Transform c = Instantiate(coin);
                inpos = new Vector3(x * 3.5f, 3f, 3.5f * z);
                c.localPosition = inpos;
                c.SetParent(insta);
            }
        }
    }

    // Update is called once per frame
    void Update () {
		
	}
}

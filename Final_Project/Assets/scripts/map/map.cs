 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class map : MonoBehaviour {
    public int[] gamemap = new int[900];
    // Use this for initialization
    private void Awake()
    {
    }
    void Start () {
       
    }
	public void buildmap()
    {
        for (int i = 0; i < 900; i++)
        {
            if (i < 3)
                gamemap[i] = 0;
            else
                gamemap[i] = Random.Range(0, 8);
        }
    }
	// Update is called once per frame
	void Update () {
		
	}
}
 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class map : MonoBehaviour {
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
                GameData.gamemap[i] = 0;
            else
                GameData.gamemap[i] = Random.Range(0, 8);
        }
    }
	// Update is called once per frame
	void Update () {
		
	}
}
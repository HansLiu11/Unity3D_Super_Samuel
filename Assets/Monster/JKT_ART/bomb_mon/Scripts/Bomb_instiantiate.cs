using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bomb_instiantiate : MonoBehaviour {
    public Transform Bomb;
	// Use this for initialization
	void Start () {
        for(int i = 0; i < 4; ++i)
        {
            Transform c = Instantiate(Bomb);
            int x = Random.Range(55, 85);
            int z = Random.Range(117, 140);
            c.localPosition = new Vector3(x, 45, z);
        }   
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}

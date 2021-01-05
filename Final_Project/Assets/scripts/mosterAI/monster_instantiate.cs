using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class monster_instantiate : MonoBehaviour {
    public Transform monster1;
    NavMeshAgent NMA;//導航控制組件
    // Use this for initialization
    void Start () {
        for(int i = 1; i < Random.Range(15,25); ++i)
        {
            int x = Random.Range(-90,10);
            int z = Random.Range(330,450 );
            Vector3 p = new Vector3(x, 3.5f, z);
            Transform c =  Instantiate(monster1);
            c.parent = transform;
            NMA = c.GetComponent<NavMeshAgent>();
            NMA.Warp(p);
            //c.gameObject.SetActive(false);
        }
        
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

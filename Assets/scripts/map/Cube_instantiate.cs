using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube_instantiate : MonoBehaviour {
    public Transform cube;
    //[SerializeField] int r;
    // Use this for initialization
    void Start () {
        int r = 30;
        //int num = Random.Range(200, 300);
        for (int i = 0; i < 120; i++)
        {
            Transform c = Instantiate(cube);
            int randomx = Random.Range(0, r);
            //float randomy = Random.Range(-r, r);
            int randomz = Random.Range(0, r);
            Vector3 inspos = new Vector3(randomx* 3.5f, 0, randomz* 3.5f);
            c.localPosition = inspos;
        }
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}

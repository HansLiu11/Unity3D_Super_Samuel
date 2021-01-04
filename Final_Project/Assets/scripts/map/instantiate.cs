using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class instantiate : MonoBehaviour {
    public Transform cube2;
    public Transform cube1;
    public Transform cube;
    public Transform coin;
    int x, z,high,coingenerate;
    Vector3 inspos, inspos2;
    map map1=new map();
    // Use this for initialization
    void Start () {
        map1.buildmap();
        for (int i = 0; i < 900; i++)
        {
            x = i / 30;
            z = i % 30;
            switch (map1.gamemap[i])
            {
                case 3:
                    Transform b = Instantiate(cube1);
                    inspos = new Vector3(x * 3.5f, 0, z * 3.5f);
                    b.localPosition = inspos;
                    //Debug.Log("1");
                    break;
                case 4:
                    Transform a = Instantiate(cube);
                    inspos = new Vector3(x * 3.5f, 0, z * 3.5f);
                    a.localPosition = inspos;
                    //Debug.Log("2");
                    break;
                case 5:
                    Transform c = Instantiate(cube2);
                    inspos = new Vector3(x * 3.5f, 0, z * 3.5f);                   
                    c.localPosition = inspos;
                    //Debug.Log("3");
                    break;
                default:
                    
                    break;
            }
            coingenerate = Random.Range(0, 16);
            if (coingenerate<1)
            {
                Debug.Log("ergferg");
                //high = Random.Range(0, 2);
                Transform d = Instantiate(coin);
                inspos = new Vector3(x * 3.5f, 1.5f, z * 3.5f);
                inspos2 = new Vector3(x * 3.5f, 3.5f, z * 3.5f);
                if (map1.gamemap[i]==4|| map1.gamemap[i] == 5)
                {
                    d.localPosition = inspos;
                }
                else
                {
                    d.localPosition = inspos2;
                }
            }
        }
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestManager : MonoBehaviour {
    private int Coins;
    private int Lifes;
    private int Score;
	// Use this for initialization
	void Start ()
    {
        Coins = GameData.Coins;
        Lifes = GameData.Lifes;
        Score = GameData.Score;		
	}
	
	// Update is called once per frame
	void Update ()
    {

		
	}

}

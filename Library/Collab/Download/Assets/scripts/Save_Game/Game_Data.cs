using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]
static public class GameData
{
    public static int Coins = 0;
    public static int Lifes = 10;
    public static int Score = 0;
    public static string Names;
    public static int[] gamemap = new int[900];
    //
    public static int Church_1 = 0;
    public static bool Church_1_in = true;
    public static int Setfloor = 0;
    public static Vector3 Bulletdic;
    public static int BulletNum = 0;
    //
    public static bool key_1 = false;
    public static bool key_2 = false;
    public static bool key_3 = false;
    //
    public static bool save_here = false;
}
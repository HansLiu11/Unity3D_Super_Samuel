using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
public class Data
{
    public string name_1;
    public int time_1;
    public int Coins_1;
    public string name_2;
    public int time_2;
    public int Coins_2;
    public string name_3;
    public int time_3;
    public int Coins_3;
}
public class Save_top_10 : MonoBehaviour
{
    string LoadData;
    Data MyData;
    // Use this for initialization
    void Start()
    {
        LoadData = File.ReadAllText(System.IO.Path.Combine(Application.dataPath, "Top3.json"));
        //把字串轉換成Data物件
        MyData = JsonUtility.FromJson<Data>(LoadData);

    }
    void Check()
    {
        MyData.name_1 = GameData.Names;
        MyData.time_1 = GameData.Score / 60;
        MyData.Coins_1 = GameData.Coins + 10 * GameData.Lifes;
        {
            if (GameData.Score < MyData.time_1)//新的最小
            {
                MyData.name_3 = MyData.name_2;
                MyData.name_2 = MyData.name_1;
                MyData.name_1 = GameData.Names;
                MyData.time_3 = MyData.time_2;
                MyData.time_2 = MyData.time_1;
                MyData.time_1 = GameData.Score;
                MyData.Coins_3 = MyData.Coins_2;
                MyData.Coins_2 = MyData.Coins_1;
                MyData.Coins_1 = GameData.Coins;
            }
            else//新的比第一大
            {
                if (MyData.name_2 == "")//本來就無第二
                {
                    MyData.name_2 = GameData.Names;
                    MyData.time_2 = GameData.Score;
                    MyData.Coins_2 = GameData.Coins;
                }
                else
                {
                    if (GameData.Score < MyData.time_2)//比第二小
                    {
                        MyData.name_3 = MyData.name_2;
                        MyData.name_2 = GameData.Names;
                        MyData.time_3 = MyData.time_2;
                        MyData.time_2 = GameData.Score;
                        MyData.Coins_3 = MyData.Coins_2;
                        MyData.Coins_2 = GameData.Coins;
                    }
                    else//比第二大
                    {
                        if (MyData.name_3 == "")//本來就無第三
                        {
                            MyData.name_3 = GameData.Names;
                            MyData.time_3 = GameData.Score;
                            MyData.Coins_3 = GameData.Coins;
                        }
                        else
                        {
                            if (GameData.Score > MyData.time_2)//比第三小
                            {
                                MyData.name_3 = GameData.Names;
                                MyData.time_3 = GameData.Score;
                                MyData.Coins_3 = GameData.Coins;
                            }
                            
                        }
                    }
                }
            }
        }
    }

    void Write()
    {
        string a = JsonUtility.ToJson(MyData);
        StreamWriter file = new StreamWriter(System.IO.Path.Combine(Application.dataPath, "Top3.json"));
        file.WriteLine(a);
        file.Close();
    }
    private void Update()
    {
        if(GameData.save_here)
        {
            Check();
            Write();
     
            GameData.save_here = false;
        }

    }
}

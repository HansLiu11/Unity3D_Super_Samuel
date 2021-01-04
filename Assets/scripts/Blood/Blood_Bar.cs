using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;




public class Blood_Bar : MonoBehaviour
{
    public Slider slider;
    public Gradient gradient;
    public void SetHealth(int Health)
    {
        slider.value = Health;
    }
    public void SetMaxHealth(int Health,int Health_MAX)
    {
        slider.value = Health;
        slider.maxValue = Health_MAX;
    }
}
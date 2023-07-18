using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class bar : MonoBehaviour
{
 
    public Slider slider;
    

    public void SetMaxHealth(int health)
   {
    slider.maxValue = health;
    slider.value = health;

   }
    public void SetHealth(int rhealth)
    {
        slider.value = rhealth;
    }
}

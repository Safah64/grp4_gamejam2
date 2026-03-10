using UnityEngine;
using UnityEngine.UI;
public class healthBarScript : MonoBehaviour
{
    // hela gjort av Montaser

    public Slider slider;
   
    public void SetMaxHealth(int health)
    {
        slider.maxValue = health;
        slider.value = health;
       
    }
    public void SetHealth(int health)
    {
        slider.value = health;
    }
}

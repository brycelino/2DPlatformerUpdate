using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; //Allows the use of UI elements in unity
public class HealthBar : MonoBehaviour
{
    private RectTransform bar; //Declare bar as a RectTransform to allow the use of our health bar
    
    // Start is called before the first frame update
    void Start()
    {
        bar = GetComponent<RectTransform>(); // intialize bar with rectTransform to obtain the with the healthbar from unity 
        SetSize(PlayerHealth.Currenthealth);

        
    }

   public void Damage(float damage) //Method for the player taking damage. Accepts parameter damage which will control how much damage is done 
    {

        if((PlayerHealth.Currenthealth -= damage) >= 0f)// if we subtract players health from damage and the result is greater than or equal to zero we take off said amount of health
        {
            PlayerHealth.Currenthealth -= damage; // players health subtract by damage
        }       
        else // if players health becomes less than zero 
        {
            PlayerHealth.Currenthealth = 0; // player health will be 0
        }
       
        SetSize(PlayerHealth.Currenthealth); // will pass player health to the set size methof 
    }

    public void Heal()
    {
        PlayerHealth.Currenthealth = PlayerHealth.Maxhealth;

         SetSize(PlayerHealth.Currenthealth);
    }

    public void SetSize(float size) // Method that will accepts players health
    {
        bar.localScale = new Vector3(size, 1f); // the scale of the bar on the x axis will now repersent players health
    }
}

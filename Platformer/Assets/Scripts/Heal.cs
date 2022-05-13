using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Heal : MonoBehaviour
{
    public PlayerController pc;
    public HealthBar hb;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == ("Regen") && GameManager.instance.Lives > 0 )

        {
            hb.Heal();
        }
       
    }
    
    
}

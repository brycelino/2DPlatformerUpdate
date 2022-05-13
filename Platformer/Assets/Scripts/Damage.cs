using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damage : MonoBehaviour
{
    public HealthBar healthBar;
    public PlayerController pc;
    
    
    private void OnTriggerStay2D(Collider2D collision)
    {
        if(collision.tag == "Spike")
        {
            healthBar.Damage(0.003f);
        }
        if(PlayerHealth.Currenthealth == 0 && GameManager.instance.Lives > 0)
        {
            transform.position = pc.respawnPosition;
            GameManager.instance.Lives--;
            
        }
        
    }
    
}

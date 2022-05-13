using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class PlayerDeath : MonoBehaviour
{
    public HealthBar hb;
    public void DeadPlayer()
    {
        SceneManager.LoadScene(0);
        GameManager.instance.Lives = 3;
        hb.Heal();
    }
}

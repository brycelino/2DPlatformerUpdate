using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CollectingCoin : MonoBehaviour
{
     
    private void OnTriggerEnter2D(Collider2D collider2D)
    {
        if (collider2D.gameObject.CompareTag("Coin"))
        {
            GameManager.instance.score++;
            Destroy(collider2D.gameObject);
        }

        if(collider2D.gameObject.CompareTag("Door") && GameManager.instance.score == 5)
        {
            SceneManager.LoadScene(3);
        }
    }

}

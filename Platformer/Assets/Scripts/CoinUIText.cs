using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinUIText : MonoBehaviour
{
    Text PlayerCoins;
    // Start is called before the first frame update
    void Start()
    {
        PlayerCoins = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        PlayerCoins.text = "Coins: " + GameManager.instance.score;
    }
}

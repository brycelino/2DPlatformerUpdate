using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class PlayerLivesText : MonoBehaviour
{
    Text Playerlives;
    // Start is called before the first frame update
    void Start()
    {
        Playerlives = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        Playerlives.text = "Lives: " + GameManager.instance.Lives;
    }
}

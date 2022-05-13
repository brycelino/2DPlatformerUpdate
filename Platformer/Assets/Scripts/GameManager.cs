using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
   public static GameManager instance;

    public int score = 0;
    public int Lives = 3;
    
    
    // Start is called before the first frame update
    void Start()
    {
        if(instance == null)
        {
            instance = this;
        }
        
        else
        {
            Destroy(gameObject);
        }

        DontDestroyOnLoad(gameObject);
    }

   
}

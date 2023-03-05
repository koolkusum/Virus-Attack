using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
     public static GameManager instance;

   private void Awake()
   { 
    if(GameManager.instance != null)
    {
        Destroy(gameObject);
        return;
    }
        instance = this;
        
        //SceneManager.sceneLoaded += SaveState;
        //SceneManager.sceneLoaded+=LoadState;

        DontDestroyOnLoad(gameObject);

   }
      public int creeperdead;

}

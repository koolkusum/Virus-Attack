using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Portal : Collidable
{
     protected override void OnCollide(Collider2D coll)
    {
        //GameManager.instance.ShowText();
        if(coll.name=="Player")
        {
            //teleport the player
            //GameManager.instance.SaveState();
            //string sceneName=sceneNames[Random.Range(0,sceneNames.Length)];
            UnityEngine.SceneManagement.SceneManager.LoadScene("outside");
            //coll.gameObject.transform.position=Vector3(-1.546,1.318,0);
        }
    }
}

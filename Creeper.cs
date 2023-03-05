using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//public Text score;
//public int scoreNum=0;
public class Creeper : MonoBehaviour
{
  private int scoreNum;
      public DialogueTrigger trigger;
public Text score;
//int scoreNum=0;
void Start()
{
  scoreNum=0;
}
  private void OnCollisionEnter2D(Collision2D collision)
  {
    if (collision.gameObject.CompareTag("Player")==true)
    {
      scoreNum+=1;
        //GameManager.instance.creeperdead= GameManager.instance.creeperdead+1;
        //scorenum=GameManager.instance.creeperdead;
        score.text ="Creepers: " + scoreNum;
         trigger.StartDialogue();
        Destroy(this.gameObject, 2f);
    }
  }
}

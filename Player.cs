using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    protected BoxCollider2D boxCollider;
  protected Vector3 moveDelta;
  protected RaycastHit2D hit;
  protected Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        boxCollider= GetComponent<BoxCollider2D>();
        animator= GetComponent<Animator>();
            //spriteRenderer = GetComponent<SpriteRenderer>();

    DontDestroyOnLoad(gameObject);
    }

    // Update is called once per frame
private void FixedUpdate()
{
    float x = Input.GetAxisRaw("Horizontal");
    float y = Input.GetAxisRaw("Vertical");
    moveDelta= new Vector3(x, y, 0);
    if(moveDelta.x!=0 ||moveDelta.y!=0)
    {
        animator.SetFloat("X",moveDelta.x);
        animator.SetFloat("Y",moveDelta.y);
        animator.SetBool("IsWalking",true);
    }
    else{
        animator.SetBool("IsWalking",false);
    }
        /*
        //swap sprite direction whether ur going right or left
        if(moveDelta.x>0)
        {
            transform.localScale = Vector3.one;

        }
        else if(moveDelta.x<0)
        {
            transform.localScale = new Vector3(-1,1,1);
        }*/
     
     //actor hits a blocking layer ex. a wall
     //make sure we can move in this direction bycasting bos if box returns null we are free to move
       hit=Physics2D.BoxCast(transform.position,boxCollider.size,0,new Vector2(0,moveDelta.y), Mathf.Abs(moveDelta.y*Time.deltaTime), LayerMask.GetMask("Actor","Blocking"));
        
        if(hit.collider==null)
        {
       // movement
        transform.Translate(0,moveDelta.y * Time.deltaTime,0);
        }

            hit=Physics2D.BoxCast(transform.position,boxCollider.size,0,new Vector2(moveDelta.x,0), Mathf.Abs(moveDelta.x*Time.deltaTime), LayerMask.GetMask("Actor","Blocking"));
        
        if(hit.collider==null)
        {
       // movement
        transform.Translate(moveDelta.x * Time.deltaTime,0,0);
        }
}

}

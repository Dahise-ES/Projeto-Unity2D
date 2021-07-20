using System.Numerics;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed = 5f;
    public Rigidbody2D playerRb;
    public Animator animator;

    UnityEngine.Vector2 movimento;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        movimento.x = Input.GetAxisRaw("Horizontal");
        movimento.y = Input.GetAxisRaw("Vertical");

        animator.SetFloat("horizontal", movimento.x);
        animator.SetFloat("vertical", movimento.y);
        animator.SetFloat("velocidade", movimento.sqrMagnitude);

        if(movimento != UnityEngine.Vector2.zero){
            animator.SetFloat("horizontal_idle", movimento.x);
            animator.SetFloat("vertical_idle", movimento.y);
        }
    }

     void FixedUpdate()
    {
        playerRb.MovePosition(playerRb.position + movimento.normalized * speed * Time.fixedDeltaTime);
    }
    /*void OnTriggerEnter2D(Collider2D other)
    {
        speed = 0;
    }*/
}

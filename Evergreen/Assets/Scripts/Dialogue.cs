using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dialogue : MonoBehaviour
{
    public Sprite profile;
    public string[] speechTxt;
    public string actorName;

    public LayerMask playerLayer;
    public float radious;
    public bool onRadious;


    private DialogueControl dc;

    void Start()
    {
        dc = FindObjectOfType<DialogueControl>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && onRadious)
        {
        dc.Speech(profile, speechTxt, actorName);
        }
    }
   
    public void Interact()
    {
        Collider2D hit = Physics2D.OverlapCircle(transform.position, radious, playerLayer);

        if(hit != null)
        {
            onRadious = true;
            
        }
        else
        {
            onRadious = false;
        }
    }

    private void FixedUpdate()
    {
        Interact();
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.DrawWireSphere(transform.position, radious);
    }
}

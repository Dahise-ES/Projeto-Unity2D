using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZonaVermelha : MonoBehaviour
{
    public GameObject danger;
    public Collider2D colliderDanger;

    void OnTriggerEnter2D(Collider2D colliderDanger)
    {
        
        if (colliderDanger.CompareTag("Player"))
        {
            danger.SetActive(true);

        }

    }

    void OnTriggerExit2D(Collider2D colliderDanger)
    {
        if (colliderDanger.CompareTag("Player"))
        {
            danger.SetActive(false);

        }
    }
}

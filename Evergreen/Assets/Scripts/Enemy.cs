using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public Collider2D colisor;
    public TrocaCena efeito;
    public GameObject fala;
    public float tempo;
    public MovingPlatform inimigo;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D colisor)
    {
        if (colisor.CompareTag("Player"))
        {

            StartCoroutine(Pego());
        }
       
    }

    IEnumerator Pego()
    {
        inimigo.setFinal();
        fala.SetActive(true);
        yield return new WaitForSeconds(tempo);
        efeito.IniciaTransicao(5);
    }
    
}

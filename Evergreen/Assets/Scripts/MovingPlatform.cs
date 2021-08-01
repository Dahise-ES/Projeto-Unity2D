using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatform : MonoBehaviour
{
    //velocidade da plataforma
    public float speed;
    //array com os pontos
    public Transform[] wayPoints;
    //tempo de espera entre as idas aos pontos
    public float waitTime;

    //dire��o para controlar se indo para esq ou dir
    private float dir = 1;
    //indices dos pontos
    private int index;
    //controlar quando gnt t� esperando o tempo
    private bool wait;
    private float timer;

    private bool first = true;
    public bool final = false;

    public Animator animator;

    public void setFinal()
    {
        this.final = true;
    }
    // Update is called once per frame
    void Update()
    {
        if (!final)
        {
        if(wait)
        {
            CoutingWaitTime();

            return;//sair da fun�ao e n�o faz o que esta abaixo
        }
        ChangeWayPoints();
        Moving();
        if(first == true){
        animator.SetFloat("horizontal", dir);
        }
        else{
        animator.SetFloat("horizontal", -(dir));

        }
        
        animator.SetBool("movimento", !wait);

        }
    }

  

    void Moving()
    {
        //fazer a plataforma andar de um ponto a ponto a outro que vamos configurar
        if (!final)
        {
        transform.position = Vector2.MoveTowards(transform.position, wayPoints[index].position, speed * Time.deltaTime);

        }
    }

    //contar o tempo
    void CoutingWaitTime()
    {
        timer += Time.deltaTime;
        if (timer >= waitTime)
        {

            wait = false;
            timer = 0;
        }
    }

    void ChangeWayPoints()
    {
        //calcular a distancia de um ponto a outro;
        //primeiro par�metro � nossa  posi��o e o segundo � a posi��o que se quer chegar
        float distance = Vector2.Distance(transform.position, wayPoints[index].position);

        if (dir > 0 && distance <= 0)
        {
            //passar para o pr�ximo ponto
            index++;
            //verificar para n�o dar erro. Pois, o index n�o pode ser maior que os pontos 
                this.first = false;
            if (index >= wayPoints.Length)
            {
                //passa o valro do index para o �ltimo valor do wayponts
                //pq a contagem no array come�a de zero
                index = wayPoints.Length - 1;
                dir = -1;
                wait = true;
  
            }

        }
        //voltando (esquerda)
        else if (dir < 0 && distance <= 0)
        {
            index--;
            if (index < 0)
            {
                index = 0;
                dir = 1;
                wait = true;
                
            }

        }

    }

    //quando colider com o player trasforma ele no seu "filho" 
    //para que ele possa ser transportado pela plataforma
    /* private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            collision.transform.SetParent(transform);
        }
    }

    //Quando o player sair da colis�o, deixar de ser filho da plataforma m�vel
    private void OnCollisionExit2D (Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            collision.transform.SetParent(null);
        }
    }
*/
}

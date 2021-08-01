using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TrocaCena : MonoBehaviour
{
    [SerializeField] private Animator animator;
    private int cenaIndice;
    private Scene cenaAtual;
   
    //Esse m�todo � chamado em qualquer evento que troque a cena do jogo
    public void IniciaTransicao(int _cenaIndice)
    {
        cenaIndice = _cenaIndice;
        animator.SetTrigger("Inicia");
    }

    //Esse m�todo � chamado no final da anima��o
    public void trocaCena()
    {
        cenaAtual = SceneManager.GetActiveScene();
       
        if(cenaAtual.name == "estagio2")
        {
            SceneManager.LoadScene("Fim");
        }
        SceneManager.LoadScene(cenaIndice);
    }
}

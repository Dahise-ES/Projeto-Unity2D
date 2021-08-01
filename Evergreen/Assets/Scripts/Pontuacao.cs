using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pontuacao : MonoBehaviour
{
    private GameObject[] arvores;
    public Text atual;
    public Text total;
    private int pontos;
    public TrocaCena efeito;
    // Start is called before the first frame update
    void Start()
    {
        arvores = GameObject.FindGameObjectsWithTag("plantas");
    }

    // Update is called once per frame
    void Update()
    {
        atual.text = pontos.ToString();
        total.text = arvores.Length.ToString();

        if(pontos == arvores.Length)
        {
            efeito.IniciaTransicao(4);
        }
    }

    public void adicionarPonto()
    {
        this.pontos++;
    }
}

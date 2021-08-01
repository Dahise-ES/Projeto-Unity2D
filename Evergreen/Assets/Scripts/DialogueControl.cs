using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueControl : MonoBehaviour
{
    [Header("Components")]
    public GameObject dialogueObj;
    public Image profile;
    public Text speechText;
    public Text actorNameText;

    [Header("Settings")]
    public float typingSpeed;
    private string[] sentences;
    private int index;
    

    public void Speech(Sprite P, string[] txt, string actorName)
    {
        dialogueObj.SetActive(true);
        profile.sprite = P;
        sentences = txt;
        actorNameText.text = actorName;
    } 

    /*
    IEnumerator TypeSentence()
    {
        foreach(char letter in sentences[index].ToCharArray())
        {
            speechText.text += letter;
            yield return new WaitForSeconds(typingSpeed);
        }
    }*/

    public void NextSentence()
    {
        if(speechText.text == sentences[index])
        {
            index++;
            speechText.text = "";
        }
        else
        {
            speechText.text = "";
            index = 0;
            dialogueObj.SetActive(false);
        }
    }
}

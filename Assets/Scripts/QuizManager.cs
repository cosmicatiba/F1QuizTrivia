using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuizManager : MonoBehaviour
{
    public List<questionandanswers> QnA;
    public GameObject[] options;
    public int currentquestion;
    public Text questionTxt;

    private void Start()
    {
        generatequestion();
    
    }
    void Setanswers()
    {
        for (int i = 0; i < options.Length; i++)
        {
            options[i].transform.GetChild(0).GetComponent <Text>().text= QnA[currentquestion].answers[i];
        }
    }
    void generatequestion()
    {
        currentquestion = Random.Range(0, QnA.Count);
        questionTxt.text = QnA[currentquestion].question;
    }

}



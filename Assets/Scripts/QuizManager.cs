using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class QuizManager : MonoBehaviour
{
    public List<questionandanswers> QnA;
    public GameObject[] options;
    public int currentquestion;
    public Text questionTxt;
    public Text ScoreTxt;
    int TotalQuestion=0;
    public int score;
    public GameObject Quizpanel;
    public GameObject Gopanel;

    private void Start()
    {
        TotalQuestion = QnA.Count;
        Gopanel.SetActive(false);
        generatequestion();
        QnA.RemoveAt(currentquestion);
    }
    public void retry()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    void Gameover()
    {
        Quizpanel.SetActive(false);
        Gopanel.SetActive(true);
        ScoreTxt.text=score +"/"+ TotalQuestion;
    }
    public void correct()
    {
        score += 5;
        QnA.RemoveAt(currentquestion);
        generatequestion();
    }
    public void wrong()
    {
        QnA.RemoveAt(currentquestion);
        generatequestion();

    }
    void Setanswers()
    {
        for (int i = 0; i < options.Length; i++)
        {
            options[i].GetComponent<AnswersScript>().isCorrect = false;
            options[i].transform.GetChild(0).GetComponent <Text>().text= QnA[currentquestion].answers[i];
            if (QnA[currentquestion].correctanswers == i + 1)
            {
                options[i].GetComponent<AnswersScript>().isCorrect = true;
 
            }

        }
    }
    void generatequestion()
    {
        if(QnA.Count>0)
        { 

        currentquestion = Random.Range(0, QnA.Count);
        questionTxt.text = QnA[currentquestion].question;
        Setanswers();
        }
        else
        {
            Debug.Log("Sorularımız Bitti...");
            Gameover();
        }
;    }

}



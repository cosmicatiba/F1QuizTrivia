using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadLeaderboard : MonoBehaviour
{
    public void OpenLevel()
    {
        SceneManager.LoadScene("Leaderboard");
    }
}

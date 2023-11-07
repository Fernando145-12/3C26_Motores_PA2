using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class GameOverController : MonoBehaviour
{
    public Score scoreData;
    public Button btnPlay;

    public TMP_Text textScore;
    // Start is called before the first frame update
    void Start()
    {
        btnPlay.onClick.AddListener(() => ReturnMenu());

        textScore.text = "Current Score" + scoreData.curretScore.ToString("000");
    }

    void ReturnMenu()
    {
        SceneManager.LoadScene("Menu");
    }
}

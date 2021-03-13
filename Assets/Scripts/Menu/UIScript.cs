using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UIScript : MonoBehaviour
{
    public int BestTimeCount;
    public Text BestTimeText;


    public void ChangeScene(string sceneName)
    {

        SceneManager.LoadScene(sceneName);
    }
    public void QuitGame()
    {
            Application.Quit();
    }
    public void Update()
    {
            BestTimeCount = PlayerPrefs.GetInt("SaveScore");
            BestTimeText.text = "Лучшее время:" + BestTimeCount;
    }
    public void Start()
    {
            BestTimeText = GameObject.Find("BestTime").GetComponent<Text>();
    }
    
}


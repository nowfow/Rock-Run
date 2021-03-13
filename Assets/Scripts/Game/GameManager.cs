using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {

    public static GameManager instance;

    public Text timer_Text;
    public int timer_Count;
    public Text timer_best;
    public int timer_bestCount;


    void Awake() {
        MakeSingleton();
        if (PlayerPrefs.HasKey("SaveScore"))
        {
            timer_bestCount = PlayerPrefs.GetInt("SaveScore");
        }
        
    }

	void Start () {
        StartCoroutine(CountTime());
        timer_Text = GameObject.Find("Timer").GetComponent<Text>();
        timer_best = GameObject.Find("TimerBest").GetComponent<Text>();
    }

	void MakeSingleton() {

        if(instance == null) {
            instance = this;
        }
    }
	
    public void ResetValues() {
        timer_Count = 0;
        Time.timeScale = 0f;
    }

    public void RestartGame() {
        StartCoroutine(RestartGameAfterTime());
    }

    IEnumerator RestartGameAfterTime() {
        yield return new WaitForSecondsRealtime(1.5f);

        UnityEngine.SceneManagement.SceneManager.LoadScene(
            UnityEngine.SceneManagement.SceneManager.GetActiveScene().name);
    }

    IEnumerator CountTime() {
        yield return new WaitForSeconds(1f);

        timer_Count++;
        BestScore();

        timer_Text.text = "Время: " + timer_Count;
        timer_best.text = "Лучший: " + timer_bestCount;

        StartCoroutine(CountTime());

    }
    public void BestScore()
    {
        if (timer_Count > timer_bestCount)
        {
            timer_bestCount = timer_Count;
        }
        PlayerPrefs.SetInt("SaveScore", timer_bestCount);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberCar : MonoBehaviour
{
    private int numberPlayer;

    public GameObject Player1;
    public GameObject Player2;
    public GameObject Player3;

    void Start()
    {
        numberPlayer = PlayerPrefs.GetInt("Player");
    }

    void Update()
    {
        if(numberPlayer == 1)
        {
            Player1.SetActive(true);
            Player2.SetActive(false);
            Player3.SetActive(false);
        }

        if (numberPlayer == 2)
        {
            Player2.SetActive(true);
            Player1.SetActive(false);
            Player3.SetActive(false);

        }
        if (numberPlayer == 3)
        {
            Player3.SetActive(true);
            Player1.SetActive(false);
            Player2.SetActive(false);
        }
    }
}

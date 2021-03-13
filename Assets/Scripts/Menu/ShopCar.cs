using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopCar : MonoBehaviour
{

    private int numberPlayer;

    // Start is called before the first frame update
    void Start()
    {
        numberPlayer = PlayerPrefs.GetInt("Player");
    }


    public void PlayerOwl()
    {
        numberPlayer = 1;
        PlayerPrefs.SetInt("Player", numberPlayer);
    }

    public void PlayerPink()
    {
        numberPlayer = 2;
        PlayerPrefs.SetInt("Player", numberPlayer);
    }
    public void PlayerDude()
    {
        numberPlayer = 3;
        PlayerPrefs.SetInt("Player", numberPlayer);
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class IsEnabled : MonoBehaviour
{
    public int NeedToUnlock;
    public Color NewColor;
    public GameObject BlockPink;
    public GameObject BlockDude;
    void Start()
    {
        if (PlayerPrefs.GetInt("SaveScore") < NeedToUnlock)
        {
            GetComponent<SpriteRenderer>().color = Color.black;

        }

    }
    public void PINKM()
    {
        if (PlayerPrefs.GetInt("SaveScore") < NeedToUnlock)
        {
            BlockPink.SetActive(true);
        }
       
    }
    public void DUDEM()
    {
        if (PlayerPrefs.GetInt("SaveScore") < NeedToUnlock)
        {
            BlockDude.SetActive(true);
        }

    }
    public void Update()
    {
        PINKM();
        DUDEM();
    }
}
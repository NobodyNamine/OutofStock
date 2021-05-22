using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    static int numOfPS5 = 0;
    static int levelNum = 0;

    public Text Timer;
    public Text PS5Indicator;
    public bool PurchasedPS5;

    // Start is called before the first frame update
    void Start()
    {
        PS5Indicator.text = numOfPS5.ToString();
        PurchasedPS5 = false;
    }

    // Update is called once per frame
    void Update()
    {
        TimeRanOut();
    }

    public void TimeRanOut()
    {
        if ((int.Parse(Timer.text) <= 0) && PurchasedPS5 == false)
        {
            int randNum = Random.Range(1, 4);

            increaseLevelNum();

            //Show one random of 3 fail screens
            switch (randNum)
            { 
                case 1:
                    SceneManager.LoadScene("Fail1");
                    break;
                case 2:
                    SceneManager.LoadScene("Fail2");
                        break;
                case 3:
                    SceneManager.LoadScene("Fail3");
                    break;
            }
            
        }
    }

    public void ButtonSuccesfullyPushed()
    {
        Debug.Log("Button PUshed!");
            increaseLevelNum();
             PurchasedPS5 = true;
            numOfPS5++;
            PS5Indicator.text = numOfPS5.ToString();
            SceneManager.LoadScene("Success");            
    }

    public void increaseLevelNum()
    {
        levelNum++;
    }

}


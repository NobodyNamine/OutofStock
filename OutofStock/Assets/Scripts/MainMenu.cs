using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MainMenu : MonoBehaviour
{
    //Main Menu Logic
    const int numOfLevels = 4; //Assuming Main Menu -> Game -> Result
    public void PlayGame()
    {
        if (SceneManager.GetActiveScene().buildIndex <= (numOfLevels-1))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            Debug.Log("Going to next scene");
        }
        else
        {
            //go back to main menu if no screens left
            SceneManager.LoadScene(0);
            Debug.Log("Going to Main Menu");

        }



    }

    public void Again()
    {
        SceneManager.LoadScene(0);
        Debug.Log("Going to Main Menu");
    }

    //quits the game
    public void QuitGame()
    {
        Application.Quit();
    }

}

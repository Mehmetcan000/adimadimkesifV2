using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class LevelMenuManager : MonoBehaviour
{

    public void HangiOyunAcilsin(string levelName) //Hangi Sahne Açýlacak

    {
        PlayerPrefs.SetString("levelName", levelName);
        

        if (levelName == "Level01")
        {
            SceneManager.LoadScene("Level01");
        }
        else if(levelName == "Level02" )
        {
            SceneManager.LoadScene("Level02");
        }

       
    }

    public void TurnBack()
    {

        SceneManager.LoadScene("MainMenu");

    }



}

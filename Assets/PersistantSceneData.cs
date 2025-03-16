using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PersistantSceneData : MonoBehaviour
{
    //any data that needs to be retained between scenes can go into this script

    GameData gd = new GameData();
    public SavingScript saveScript;  

    public void SaveLevelScore() //used at the end of the main gameloop so that data can be save highscore can be save for use in the end screen
    {
        GameObject levelManager = GameObject.Find("GameManager");
        score scoreScript = levelManager.GetComponent<score>();

        gd = saveScript.GetGameData();

        if(scoreScript.points > gd.Highscore)
        {
            saveScript.EditValues(scoreScript.points, scoreScript.timePassedSeconds);
        }

        gd = null;
        scoreScript = null;
        levelManager = null;
    }
}

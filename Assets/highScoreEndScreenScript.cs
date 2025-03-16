using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.UI;
using TMPro;

public class highScoreEndScreenScript : MonoBehaviour
{
    GameData gameData = new GameData();
    string saveFileLocation;

    string stringToPrint;
    int hightScore;
    public TMP_Text TMP;

    private void Awake()
    {
        saveFileLocation = Application.persistentDataPath + "/gamedata.json";

        if (File.Exists(saveFileLocation))
        {
            string fileContents = File.ReadAllText(saveFileLocation);
            gameData = JsonUtility.FromJson<GameData>(fileContents);
            hightScore = gameData.Highscore;
        }
        else
        {
            hightScore = 0;
            Debug.Log("File not found: " + saveFileLocation);
        }

        stringToPrint = "Highscore: " + hightScore;
        TMP.text = stringToPrint;
    }
}

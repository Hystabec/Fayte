using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class SavingScript : MonoBehaviour
{
    string saveFileLocation;

    GameData gameData = new GameData();

    private void Awake()
    {
        saveFileLocation = Application.persistentDataPath + "/gamedata.json";

        if (!File.Exists(saveFileLocation))
        {
            gameData.Highscore = 0;
            gameData.time = 0;

            string jsonString = JsonUtility.ToJson(gameData);

            File.WriteAllText(saveFileLocation, jsonString);
        }
        else
        {
            readFile();
        }
    }

    public void readFile()  //takes everything out of the json file and puts it into the file contents string
    {
        if (File.Exists(saveFileLocation))
        {
            string fileContents = File.ReadAllText(saveFileLocation);
            gameData = JsonUtility.FromJson<GameData>(fileContents);
        }
    }

    public void writeFile() //puts everything in the json string and puts it into the json file
    {
        string jsonString = JsonUtility.ToJson(gameData);

        File.WriteAllText(saveFileLocation, jsonString);
    }

    public void EditValues(int newHighscore, float newHighScoreTime)    //use this to update the highscores
    {
        gameData.Highscore = newHighscore;
        gameData.time = newHighScoreTime;

        writeFile();
    }

    public void ClearHighScore()
    {
        gameData.Highscore = 0;
        gameData.time = 0;

        string jsonString = JsonUtility.ToJson(gameData);

        File.WriteAllText(saveFileLocation, jsonString);
    }

    public GameData GetGameData()
    {
        return gameData;
    }
}

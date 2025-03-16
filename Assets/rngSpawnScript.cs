using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class rngSpawnScript : MonoBehaviour
{
    //public UnityEvent m_deathEvent;

    private Vector3 spawnPoint;

    static float spawn1 = -2;
    static float spawn2 = -1;
    static float spawn3 = 0;
    static float spawn4 = 1;
    static float spawn5 = 2;

    float[] arrayOfSpawnPoints = { spawn1, spawn2, spawn3, spawn4, spawn5 };

    public GameObject illusion;
    public GameObject fortune;
    GameObject tempSpawner;

    public GameObject player;

    float count = 0;

    public List<GameObject> pooledFortunes;
    public GameObject fortunePrefab;
    public int amountOfFortunesToSpawn = 4;

    public List<GameObject> pooledIllusions;
    public GameObject illusionPrefab;
    public int amountOfIllusionToSpawn = 20;

    void SpawnNewIllusion()
    {
        spawnPoint = new Vector3(arrayOfSpawnPoints[Random.Range(0, arrayOfSpawnPoints.Length)], 7, 0);

        tempSpawner = pooledIllusions[0];
        tempSpawner.SetActive(true);
        tempSpawner.transform.position = spawnPoint;
        pooledIllusions.Remove(tempSpawner);
        tempSpawner = null;

        //add scripts that changes sprite of the object on the fly
        //example illusion.changesprtie();

        count++;
    }

    void SpawnNewFortune()
    {
        spawnPoint = new Vector3(arrayOfSpawnPoints[Random.Range(0, arrayOfSpawnPoints.Length)], 7, 0);

        tempSpawner = pooledFortunes[0];
        tempSpawner.SetActive(true);
        tempSpawner.transform.position = spawnPoint;
        pooledFortunes.Remove(tempSpawner);
        tempSpawner = null;

        count++;
    }

    public void despawnObject(GameObject objectToDespawn)
    {
        pooledIllusions.Add(objectToDespawn);
        objectToDespawn.SetActive(false);
    }

    public void despawnFortune(GameObject fortuneToDespawn)
    {   
        pooledFortunes.Add(fortuneToDespawn);
        fortuneToDespawn.SetActive(false);
    }

    private void Start()
    {
        /*if (gameObject != null)
        {
            spawnNext();
        }*/
        pooledFortunes = new List<GameObject>();
        GameObject temp;
        temp = fortunePrefab;

        for(int i = 0; i < amountOfFortunesToSpawn; i++)
        {
            temp = Instantiate(fortunePrefab);
            temp.SetActive(false);
            pooledFortunes.Add(temp);
        }

        pooledIllusions = new List<GameObject>();
        temp = illusionPrefab;

        for(int i = 0; i < amountOfIllusionToSpawn; i++)
        {
            temp = Instantiate(illusionPrefab);
            temp.SetActive(false);
            pooledIllusions.Add(temp);
        }

        SpawnNewIllusion();

        /*if (m_deathEvent == null)
            m_deathEvent = new UnityEvent();

        m_deathEvent.AddListener(startDeathSequence);*/
    }
    public void spawnNext()
    {
        if (gameObject.scene.isLoaded)
        {
            if (count < 4)
            {
                SpawnNewIllusion();
            }
            else
            {
                SpawnNewFortune();
                count = 0;
            }
        }
    }
}

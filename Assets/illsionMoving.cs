using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class illsionMoving : MonoBehaviour
{
    private AudioSource collectionNoise;
    private GameObject gameManager;
    private rngSpawnScript spawnScript;
    private score scoreScript;
    
    float moveSpeed = 0.02f;
    float Randomscale = 1;
    int pointsToAddWhenCollectingFate = 50;

    int upperSize = 5;
    int lowerSize = 3;


    void Start()
    {
        gameManager = GameObject.Find("GameManager");
        spawnScript = gameManager.GetComponent<rngSpawnScript>();
        scoreScript = gameManager.GetComponent<score>();
        collectionNoise = gameManager.GetComponent<AudioSource>();

        if (gameObject.layer == 6)
        {
            Randomscale = Random.Range(lowerSize, upperSize);
            Randomscale = Randomscale / 10;
            gameObject.transform.localScale = new Vector3(Randomscale, Randomscale, 1);
        }

        moveSpeed += (scoreScript.timePassedSeconds / 1000);
    }

    private void OnEnable()
    {
        if (scoreScript == null) return;

        if (gameObject.layer == 6)
        {
            Randomscale = Random.Range(lowerSize, upperSize);
            Randomscale = Randomscale / 10;
            gameObject.transform.localScale = new Vector3(Randomscale, Randomscale, 1);
        }

        moveSpeed += (scoreScript.timePassedSeconds/1000);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        gameObject.transform.position = new Vector2(gameObject.transform.position.x, gameObject.transform.position.y- moveSpeed);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.layer == 10)
        {
            if (gameObject.layer == 6)
            {
                spawnScript.despawnObject(gameObject);

                //kill the player (move to endscreen)
                gameManager.GetComponent<LoadTheEndScreen>().startDeathSequence();

                //could add an explosion and a fade to black before moving to the final scene
            }
            else if (gameObject.layer == 7)
            {
                collectionNoise.Play();

                //this needs to then disable the fortune and tell the GM that it has been despawned and add it to the spawn list
                spawnScript.despawnFortune(gameObject);

                //add points to the score
                scoreScript.addPoint(pointsToAddWhenCollectingFate);                
            }
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if(other.gameObject.layer == 8)
        {
            if (gameManager)
                //spawnScript.m_spawnNext.Invoke();
                spawnScript.spawnNext();
        }
        else if(other.gameObject.layer == 9)
        {
            //call in the disable script on the GM
            if (gameObject.layer == 6)
                spawnScript.despawnObject(gameObject);
            else if (gameObject.layer == 7)
                spawnScript.despawnFortune(gameObject);
        }
    }
}

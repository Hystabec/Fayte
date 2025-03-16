using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadTheEndScreen : MonoBehaviour
{
    public GameObject spawnTrigger;
    GameObject DDOL;
    private PersistantSceneData PSD;
    public sceneFade SF;
    public GameObject playerGameObject;
    public GameObject playerBody;
    public GameObject explosionAnimGameObject;
    public GameObject scoreDisplay;
    Animator GOAnimatorComp;

    private void Awake()
    {
        DDOL = GameObject.Find("PersistentGameObject");
        PSD = DDOL.GetComponent<PersistantSceneData>();
        GOAnimatorComp = explosionAnimGameObject.GetComponent<Animator>();
    }

    public void startDeathSequence()
    {
        spawnTrigger.SetActive(false);


        explosionAnimGameObject.transform.position = playerBody.transform.position;
        GOAnimatorComp.enabled = true;
        playerGameObject.SetActive(false);
        scoreDisplay.SetActive(false);

        PSD.SaveLevelScore();
        StartCoroutine(SceneChange());   
    }

    IEnumerator SceneChange()
    {
        //could disable player and move the explosion animation on top e.g.

        /*
         disable player
         hide timer
         move explosion to player's transform and start animation
        */
        if (SF.isActiveAndEnabled)
        {
            SF.OnFadeOut();
            yield return new WaitUntil(() => SF.ready());
            SceneManager.LoadScene(2);
        }
        else
        {
            SceneManager.LoadScene(2);
        }
    }
}

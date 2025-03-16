using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerDistanceFromCentre : MonoBehaviour
{
    float minRadius = 1;
    float maxRadius = 2.5f;

    float DistanceToChangeBy = 0.03f;

    void FixedUpdate()
    {
        if(Input.GetKey(KeyCode.Space))
        {
            gameObject.transform.localPosition  = new Vector2(gameObject.transform.localPosition.x + DistanceToChangeBy, gameObject.transform.localPosition.y);
        }  
        else
        {
            gameObject.transform.localPosition = new Vector2(gameObject.transform.localPosition.x - DistanceToChangeBy, gameObject.transform.localPosition.y);
        }

        //locks the player in the lower bound
        if(gameObject.transform.localPosition.x < minRadius )
        {
            gameObject.transform.localPosition = new Vector2(minRadius- 0.03f, gameObject.transform.localPosition.y);
        }
        //locks the player in the upper bound
        if (gameObject.transform.localPosition.x > maxRadius)
        {
            gameObject.transform.localPosition = new Vector2(maxRadius + 0.03f, gameObject.transform.localPosition.y);
        }
    }
}

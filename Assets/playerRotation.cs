using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerRotation : MonoBehaviour
{
    float degreesPerSecond = 90;

    private void Update()
    {
        transform.Rotate(new Vector3(0, 0, degreesPerSecond) * Time.deltaTime);
    }
}


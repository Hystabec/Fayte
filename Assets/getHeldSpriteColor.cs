using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class getHeldSpriteColor : MonoBehaviour
{
    GameObject PGO;
    persisantColourHolder PCH;

    SpriteRenderer SR;
    void Start()
    {
        SR = gameObject.GetComponent<SpriteRenderer>();
        PGO = GameObject.Find("PersistentGameObject");
        PCH = PGO.GetComponent<persisantColourHolder>();

        SR.sprite = PCH.getHeldSprite();
        SR.color = PCH.getHeldColor();
    }
}

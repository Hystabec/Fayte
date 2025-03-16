using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class illusionSpriteSelector : MonoBehaviour
{   
    SpriteRenderer SR;
    
    public Sprite earth;
    public Sprite jupiter;
    public Sprite mercury;
    public Sprite moon;
    public Sprite saturn;
    public Sprite sun;
    public Sprite uranus;
    public Sprite venus;
    public Sprite neptune;

    Sprite[] planet;

    private void Awake()
    {
        planet = new Sprite[9];

        planet[0] = earth;
        planet[1] = jupiter;
        planet[2] = mercury;
        planet[3] = moon;
        planet[4] = sun;
        planet[5] = uranus;
        planet[6] = saturn;
        planet[7] = venus;
        planet[8] = neptune;
    }

    private void Start()
    {
        SR = gameObject.GetComponent<SpriteRenderer>();
        SR.sprite = planet[Random.Range(0, 8)];
    }

    private void OnEnable()
    {
        SR = gameObject.GetComponent<SpriteRenderer>();
        SR.sprite = planet[Random.Range(0, 8)];
    }
}

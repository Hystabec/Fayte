using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CustomerSelectorScript : MonoBehaviour
{
    GameObject PGO;
    persisantColourHolder PSH;

    SpriteRenderer SR;

    public Sprite Circle;
    public Sprite Diamond;
    public Sprite Heart;
    public Sprite Kite;
    public Sprite Octogon;
    public Sprite Rectangle;
    public Sprite Square;
    public Sprite Star;
    public Sprite Trapezoid;
    public Sprite Triangle;

    Sprite[] PCSpriteArray;

    // Start is called before the first frame update
    void Start()
    {
        PGO = GameObject.Find("PersistentGameObject");
        PSH = PGO.GetComponent<persisantColourHolder>();

        PSH.clearHeld();

        PCSpriteArray = new Sprite[10];

        PCSpriteArray[0] = Circle;
        PCSpriteArray[1] = Diamond;
        PCSpriteArray[2] = Heart;
        PCSpriteArray[3] = Kite;
        PCSpriteArray[4] = Octogon;
        PCSpriteArray[5] = Rectangle;
        PCSpriteArray[6] = Square;
        PCSpriteArray[7] = Star;
        PCSpriteArray[8] = Trapezoid;
        PCSpriteArray[9] = Triangle;

        Color PCColor = new Color32((byte)Random.Range(0, 255), (byte)Random.Range(0, 255), (byte)Random.Range(0, 255), 255);

        SR = gameObject.GetComponent<SpriteRenderer>();
        SR.sprite = PCSpriteArray[Random.Range(0, 9)];
        SR.color = PCColor;

        PSH.setHeldColor(SR.color);
        PSH.setHeldSprite(SR.sprite);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

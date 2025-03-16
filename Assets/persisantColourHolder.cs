using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class persisantColourHolder : MonoBehaviour
{
    public Sprite defaultSprite;
    Color defaultColor = new Color(1, 1, 1, 1);

    Sprite Heldsprite;
    Color Heldcolor;

    public Sprite getHeldSprite() { return Heldsprite; }
    public Color getHeldColor() { return Heldcolor; }

    public void setHeldSprite(Sprite spriteToHold) { Heldsprite = spriteToHold; }
    public void setHeldColor(Color colorToHold) { Heldcolor = colorToHold; }

    public void clearHeld() { Heldsprite = defaultSprite; Heldcolor = defaultColor; }
}

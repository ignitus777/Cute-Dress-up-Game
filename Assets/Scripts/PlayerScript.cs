using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    public Color GetColor()
    {
        return GetComponent<SpriteRenderer>().color; // grabs the sprite renderer and grabs the color and returns it.
    }

    public void SetColor(Color newColor)
    {
        GetComponent<SpriteRenderer>().color = newColor;
    }
}

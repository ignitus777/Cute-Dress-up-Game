using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneScript : MonoBehaviour
{
    public GameObject player;
    private PlayerScript playerScript;
    private float[] colors = { 0, 0, 0 };

    // Start is called before the first frame update
    void Start()
    {
        playerScript = player.GetComponent<PlayerScript>();
        Color startColor = playerScript.GetColor();
        colors[0] = startColor.r;
        colors[1] = startColor.g;
        colors[2] = startColor.b;
        
    }

    
    public void ChangePlayerColor(int rgbIndex, float colorFloat)
    {
        colors[rgbIndex] = colorFloat;
        Color tempColor = new Color(colors[0], colors[1], colors[2]);
        playerScript.SetColor(tempColor);
    }
}

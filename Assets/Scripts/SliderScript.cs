using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliderScript : MonoBehaviour
{
    private Slider slider;
    public int colorIndex = 0;
    private SceneScript sceneScript;

    // Start is called before the first frame update
    void Start()
    {
        sceneScript = GameObject.Find("SceneManager").GetComponent<SceneScript>();
        slider = gameObject.GetComponent<Slider>();
        slider.onValueChanged.AddListener(delegate { ValueChangeCheck(); });
    }

    // Update is called once per frame
    public void ValueChangeCheck()
    {

        sceneScript.ChangePlayerColor(colorIndex, slider.value);
    }
}

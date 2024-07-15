using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Box : MonoBehaviour
{
    private float startPosX;
    private float startPosY;
    private bool isBeingHeld = false; //checks to see if the (box/item) is being held by the mouse.//

    // Update is called once per frame
    void Update()
    {

        if(isBeingHeld == true)
        {
            Vector3 mousePos; // creating an empty container for x,y,and z postion of the mouse on entire screen
            mousePos = Input.mousePosition; //setting the value of mouse postion anywhere on the screen
            mousePos = Camera.main.ScreenToWorldPoint(mousePos);

            this.gameObject.transform.localPosition = new Vector3(mousePos.x - startPosX, mousePos.y - startPosY, 0);

        }
    }

    private void OnMouseDown()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 mousePos; // creating an empty container for x,y,and z postion of the mouse on entire screen
            mousePos = Input.mousePosition; //setting the value of mouse postion anywhere on the screen
            mousePos = Camera.main.ScreenToWorldPoint(mousePos);//converts the mosue postion on screen to actual postion in game.

            startPosX = mousePos.x - this.transform.localPosition.x;
            startPosY = mousePos.y - this.transform.localPosition.y;

            isBeingHeld = true;// mouse is being held down 
        }
    }

    private void OnMouseUp()
    {
        isBeingHeld = false;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisplayHandCamera : MonoBehaviour
{
    public Camera handCamera;
    public Camera mainCamera;

    public void displayHand(){
        mainCamera.enabled = false;
        handCamera.enabled = true;
    }

    public void backToBoard(){
        mainCamera.enabled = true;
        handCamera.enabled = false;
    }

}

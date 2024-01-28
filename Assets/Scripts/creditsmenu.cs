using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class creditsmenu : MonoBehaviour
{
    public Canvas CanvasObject;
    void Start(){
        CanvasObject.GetComponent<Canvas> ().enabled = false;
    }
    //Button optionmenu;
    public void Creditmenu(){
        if(CanvasObject.GetComponent<Canvas> ().enabled == false){
            CanvasObject.GetComponent<Canvas> ().enabled = true;
        }
        else if(CanvasObject.GetComponent<Canvas> ().enabled == true){
            CanvasObject.GetComponent<Canvas> ().enabled = false;
        }
    }
}

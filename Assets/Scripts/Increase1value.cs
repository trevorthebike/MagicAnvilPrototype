using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Increase1value : MonoBehaviour
{
     public TextMeshProUGUI valuetext;
     public float value2;
    // Start is called before the first frame update
    void Start(){
        updateText();
    }
    public void Clicked()
    {
        value2++;
        updateText();
    }

    void updateText(){
        valuetext.text = "Ammo: " + value2.ToString();
    }
}

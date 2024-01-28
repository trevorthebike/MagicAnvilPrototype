using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class startover : MonoBehaviour
{
   [SerializeField] private string newlevel =  "Start"; 
    public void Sceneclick(){
         Debug.Log("You have clicked the button!");
         SceneManager.LoadScene(newlevel);
    }
}

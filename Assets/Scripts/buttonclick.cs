using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class buttonclick : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
      [SerializeField] private string newlevel =  "L1";

    public void SGclick(){
         Debug.Log("You have clicked the button!");
         SceneManager.LoadScene(newlevel);
    }
}

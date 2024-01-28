using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dontdelet : MonoBehaviour
{   
    void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }
}

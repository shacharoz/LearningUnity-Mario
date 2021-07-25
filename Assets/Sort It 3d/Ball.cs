using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public string tagName;
    
    void Start()
    {
        if (this.tag == tagName) {
            Debug.Log("i have my tag ");
        }



    }
}
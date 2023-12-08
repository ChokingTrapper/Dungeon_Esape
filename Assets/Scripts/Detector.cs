using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Detector : MonoBehaviour
{
    public bool passedArea;
    

    private void Start() {
        //Debug.Log("yo2");
        passedArea = false;
        
    }

    private void OnTriggerEnter2D(Collider2D collider) {
        passedArea=true;
        
        
    }

    public void ResetEverything()
    {
        passedArea = false;
        
    }

    
 

    
}

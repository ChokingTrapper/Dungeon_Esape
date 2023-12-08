using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrickTrap : MonoBehaviour
{
    [SerializeField] Detector detector;
    [SerializeField] Transform self;
    
    bool passedOnce;
    // Start is called before the first frame update
    void Start()
    {
        self.position = Vector3.zero;
        passedOnce= false;

    }

    // Update is called once per frame
    void Update()
    {   

        if(detector.passedArea && !passedOnce)
        {
            //Debug.Log("move up");
            self.position=new Vector3(self.position.x,self.position.y+1,self.position.z);
            passedOnce = true; 
            detector.passedArea = false;

        }
    }

    public void ResetEverything()
    {
        self.position = Vector3.zero;
        passedOnce= false;
    }
}

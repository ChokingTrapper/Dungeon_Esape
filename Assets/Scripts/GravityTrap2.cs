using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravityTrap2 : MonoBehaviour
{
    [SerializeField] Detector detector;
    [SerializeField] Transform self;
    [SerializeField] Rigidbody2D selfrb2d;
    [SerializeField] float trapVelocity;
    private bool passedOnce;
    // Start is called before the first frame update
    void Start()
    {   self.position = Vector3.zero;
        selfrb2d.velocity = Vector2.zero;
        passedOnce = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(detector.passedArea && !passedOnce)
        {
            Debug.Log("yo 5");
            selfrb2d.velocity = new Vector2(selfrb2d.velocity.x,-1*trapVelocity);
            passedOnce = true; 
            detector.passedArea = false;
        }
    }

    public void ResetEverything()
    {   
        //Debug.Log("yo4");
        selfrb2d.velocity = Vector2.zero;
        self.position = Vector3.zero;
        passedOnce= false;
        
    }
}

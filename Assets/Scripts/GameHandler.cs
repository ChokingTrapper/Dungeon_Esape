using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameHandler : MonoBehaviour
{
    public bool isdead;
    [SerializeField] PlayerController2 pc2;
    //[SerializeField] TrickTrap tt1;
    //[SerializeField] TrickTrap tt2;
    //[SerializeField] TrickTrap tt3;

    [SerializeField] TrickTrap[] trickTraps;
    [SerializeField] GravityTrap2[] gravityTraps;
    [SerializeField] Detector[] detectors;
    [SerializeField] LevelChanger[] levelChangers;
    // Start is called before the first frame update
    void Start()
    {
        pc2.ResetEverything();
        for(int i=0;i<trickTraps.Length;i++)
        {
            trickTraps[i].ResetEverything();
        }
        for(int i=0;i<gravityTraps.Length;i++)
        {
            gravityTraps[i].ResetEverything();
        }
        for(int i=0;i<levelChangers.Length;i++)
        {
            levelChangers[i].ResetEverything();
        }
        for(int i=0;i<detectors.Length;i++)
        {
            detectors[i].ResetEverything();
        }
        //flv.ResetEverything();
        isdead = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(isdead)
        {
            pc2.ResetEverything();
           for(int i=0;i<trickTraps.Length;i++)
            {
            trickTraps[i].ResetEverything();
            }
            for(int i=0;i<gravityTraps.Length;i++)
            {
            gravityTraps[i].ResetEverything();
            }
            for(int i=0;i<levelChangers.Length;i++)
            {
            levelChangers[i].ResetEverything();
            }
            for(int i=0;i<detectors.Length;i++)
            {
            detectors[i].ResetEverything();
            }
            //flv.ResetEverything();
            isdead = false;
        }
    }
}

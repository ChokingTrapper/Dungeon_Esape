using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class Spikes : MonoBehaviour
{
    [SerializeField] GameObject spawnpoint;
    [SerializeField] GameObject Player;
    [SerializeField] GameHandler gh;
    
    
    void OnTriggerEnter2D(Collider2D collision)
    {
        //Debug.Log("yo1");
        if(collision.gameObject.tag=="Player")
        {
            gh.isdead = true;
        }
    }
}

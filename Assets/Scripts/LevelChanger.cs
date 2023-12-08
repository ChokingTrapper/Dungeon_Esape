using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.PlayerLoop;

public class LevelChanger : MonoBehaviour
{
    // Start is called before the first frame update
    Vector3[] levelcoords= new[] {new Vector3(-22f,0f,-10f),new Vector3(0f,0f,-10f),new Vector3(32f,0f,-10f),new Vector3(64f,0f,-10f)};
    [SerializeField] int final_level;
    [SerializeField] GameObject Camera;
    int current_level;
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other) {
        Camera.transform.position = levelcoords[final_level];
   
    }

    public void ResetEverything()
    {
        Camera.transform.position = levelcoords[0];
    }
}

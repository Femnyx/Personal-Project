using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using UnityEngine;


public class Destroy : MonoBehaviour
{
    private float xDestroy = 20.0f;

    Renderer enemy_Renderer;

    bool cameraseen;
    // Start is called before the first frame update
    void Start()
    {
        enemy_Renderer = GetComponent<Renderer>(); 
    }
    
 

    // Update is called once per frame
    void Update()
    {
        if (enemy_Renderer.isVisible)
        {
            Debug.Log("Object is visible");
            cameraseen = true;
        }
        else if (enemy_Renderer.isVisible == false && cameraseen == true) 
        {
            Destroy(gameObject);
        }


    }
}

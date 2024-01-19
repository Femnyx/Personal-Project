using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallMover : MonoBehaviour
{
    private WallManager wallManager;


    private void Awake()
    {
        wallManager = GameObject.Find("Wall").GetComponent<WallManager>();
    }

    private void OnTriggerEnter(Collider other)
    {

    }
}

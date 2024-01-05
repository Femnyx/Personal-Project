using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed;
    public bool gameOver;
    private Rigidbody PlayerRb;
    public float floatForce;
    private float gravityModifier = 1.5f;

    // Start is called before the first frame update
    void Start()
    {
        //sets the component Rigidbody on the Player and adds force the longer you hold space bar.
        PlayerRb = GetComponent<Rigidbody>();

        PlayerRb.AddForce(Vector3.up * 5, ForceMode.Impulse);
    }

    // Update is called once per frame
    void Update()
    {
        // While space is pressed and player is low enough, float up
        if (Input.GetKey(KeyCode.Space) && !gameOver)
        {
            PlayerRb.AddForce(Vector3.up * floatForce);
        }

        transform.Translate(Vector3.forward * Time.deltaTime * 5);
    }

    private void FixedUpdate()
    {
        //makes the player move forward with the set speed.
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        //destroys the ball when it hits collision (Walls).
        Destroy(gameObject);
    }
}

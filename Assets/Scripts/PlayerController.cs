using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.InputSystem;
using static UnityEngine.Rendering.DebugUI;

public class PlayerController : MonoBehaviour
{
    public float speed;
    public bool gameOver;
    private Rigidbody PlayerRb;
    public float floatForce;
    private float gravityModifier = 1.5f;
    private float vertical;
    private bool hasFly;

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
        if (hasFly && !gameOver)
        {
            Tacofly(); 
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
        SceneManager.LoadScene(4);
    }

    public void Tacofly()
    {
        PlayerRb.AddForce(Vector3.up * floatForce);
    }

    public void MoveInput(Vector2 newMoveDir)
    {
        vertical = newMoveDir.y;
    }
    


    public void OnMove(InputValue value)
    {
        MoveInput(value.Get<Vector2>());
    }

    public void JumpInput(bool newJumpState)
    {
        hasFly = newJumpState;
    }
    public void OnFly(InputValue value)
    {
        JumpInput(value.isPressed);
    }
}

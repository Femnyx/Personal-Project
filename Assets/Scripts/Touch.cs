using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Touch : MonoBehaviour
{
    private bool isTouchingScreen = false;
    private PlayerController playerController;

    private void Start()
    {
        playerController = GetComponent<PlayerController>();
    }
    void Update()
    {
        // Check if there is at least one touch on the screen
        if (Input.touchCount > 0)
        {
            // Loop through all the touches
            for (int i = 0; i < Input.touchCount; i++)
            {
                UnityEngine.Touch touch = Input.GetTouch(i);

                // Check if the touch is within the screen bounds
                if (touch.phase == TouchPhase.Began || touch.phase == TouchPhase.Moved || touch.phase == TouchPhase.Stationary)
                {
                    isTouchingScreen = true;
                }
                else if (touch.phase == TouchPhase.Ended || touch.phase == TouchPhase.Canceled)
                {
                    isTouchingScreen = false;
                }
            }
        }

        // Move the object up if the screen is being touched
        if (isTouchingScreen)
        {
            // Move the object upward
            playerController.Tacofly();
        }

    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSpeedChecker : MonoBehaviour
{
    public GameObject objectToDisappear;
    public float speedThreshold = 10f;

    private Rigidbody2D playerRigidbody;
    // Start is called before the first frame update
    void Start()
    {
        
        playerRigidbody = GetComponent<Rigidbody2D>();
        if (playerRigidbody == null)
        {
            Debug.LogError("PlayerSpeedChecker: Rigidbody not found on the player GameObject.");
            enabled = false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (playerRigidbody != null)
        {
            // Get the absolute value of the player's horizontal velocity
            float horizontalSpeed = Mathf.Abs(playerRigidbody.velocity.x);

            // Check if the horizontal speed exceeds the threshold
            if (horizontalSpeed > speedThreshold)
            {
                if (objectToDisappear != null && objectToDisappear.activeSelf)
                {
                    objectToDisappear.SetActive(false); // Deactivate the object
                    Debug.Log("Object disappeared due to high speed!");
                }
            }
            else
            {
                 //Optional: Make the object reappear if speed drops below threshold
                 if (objectToDisappear != null && !objectToDisappear.activeSelf)
                 {
                     objectToDisappear.SetActive(true);
                     Debug.Log("Object reappeared as speed is normal.");
                 }
            }
        }
    }
}

using UnityEngine;
using System;
using UnityEngine.UI; // required to use text objects and other UI elements

public class PlayerController : MonoBehaviour
{

    public float speed = 800.0f; // public to change value in the inspector 
    public static Text scoreText; // scoreText will store the UI text object
    public static int count = 0; // count will keep track of how many cubes we picked up
    public Text winText; // holds the UI text object to display Winner upon completion of the game 
    

    void FixedUpdate() // infinite loop while we are in play mode
    {
        float moveHorizontal = Input.GetAxis("Horizontal"); // Left-Right input stored as a float between -1.0 and 1.0
        float moveVertical = Input.GetAxis("Vertical");  // Down-Up input stored as a float between -1.0 and 1.0

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical); // direction of the sum of both input values 

        GetComponent<Rigidbody>().AddForce(movement * speed * Time.deltaTime); // Applies force in desired direction 

      



    }

    void OnTriggerEnter(Collider other) // when the ball enters a Trigger Collider 
    {
        if (other.gameObject.tag == "PickUp") // if the object that was entered has the tag PickUp
        {
            other.gameObject.SetActive(false); // then set that object to be inactive (hide it) 
            count += 1; // adds 1 to count each time we pick up a cube 
            scoreText.text = "Score: " + count; // Updates the text property of ScoreText
            
        }

        if (count >= 16)
        {
            winText.gameObject.SetActive(true);
        }

    }

}

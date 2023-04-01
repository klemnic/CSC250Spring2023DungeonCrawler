using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{

    private Rigidbody rb;
    public GameObject northExit, southExit, eastExit, westExit;
    public float movementSpeed = 40.0f;
    public string PlayerDirection;

    // Start is called before the first frame update
    void Start()
    {
        this.rb = this.GetComponent<Rigidbody>();
        print(MasterData.count);
    }

    // Update is called once per frame
    void Update()
    {
        //this code will allow my ball to move based on user input
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            this.rb.AddForce(this.northExit.transform.position * movementSpeed);
            this.PlayerDirection = "North";
            if (this.PlayerDirection != "North")
            {
                SceneManager.LoadScene("DungeonRoom");
            }
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            this.rb.AddForce(this.eastExit.transform.position * movementSpeed);
            this.PlayerDirection = "East";
            if (this.PlayerDirection != "East")
            {
                SceneManager.LoadScene("DungeonRoom");
            }
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            this.rb.AddForce(this.westExit.transform.position * movementSpeed);
            this.PlayerDirection = "South";
            if (this.PlayerDirection != "South")
            {
                SceneManager.LoadScene("DungeonRoom");
            }
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            this.rb.AddForce(this.southExit.transform.position * movementSpeed);
            this.PlayerDirection = "West";
            if (this.PlayerDirection != "West")
            {
                SceneManager.LoadScene("DungeonRoom");
            }
        }

    }

    //this code will load the next scene in the event that the player collides with the exit
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Exit"))
        {
            MasterData.count++;
            SceneManager.LoadScene("DungeonRoom");
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{

    private Rigidbody rb;
    public GameObject northExit, southExit, eastExit, westExit;
    public GameObject northStart, southStart, eastStart, westStart;
    public float movementSpeed = 40.0f;
    public bool isMoving;
    

    // Start is called before the first frame update
    void Start()
    {
        //we give ourselves the rigidbody because the rigidbody is what we are referring to
        this.isMoving = false;
        this.rb = this.GetComponent<Rigidbody>();

        //if our singleton is not a ? we want to transform the player to one of our exit positions
        if (!MasterData.whereDidIComeFrom.Equals("?"))
        {
            if(MasterData.whereDidIComeFrom.Equals("north"))
            {
                this.gameObject.transform.position = this.southStart.transform.position;
                this.rb.AddForce(Vector3.forward * 150.0f);
            }
            else if(MasterData.whereDidIComeFrom.Equals("west"))
            {
                this.gameObject.transform.position = this.northStart.transform.position;
                this.rb.AddForce(Vector3.right * 150.0f);
            }
            else if(MasterData.whereDidIComeFrom.Equals("east"))
            {
                this.gameObject.transform.position = this.westStart.transform.position;
                this.rb.AddForce(Vector3.right * 150.0f);
            }
            else if(MasterData.whereDidIComeFrom.Equals("south"))
            {
                this.gameObject.transform.position = this.eastStart.transform.position;
                this.rb.AddForce(Vector3.back * 150.0f);
            }

        }
        print(MasterData.count);

    }

    // Update is called once per frame
    void Update()
    {
        //this code will allow my ball to move based on user input
        if (Input.GetKeyDown(KeyCode.UpArrow) && this.isMoving == false)
        {
            this.rb.AddForce(this.northExit.transform.position * movementSpeed);
            this.isMoving = true;
            
        }
        if (Input.GetKeyDown(KeyCode.RightArrow) && this.isMoving == false)
        {
            this.rb.AddForce(this.eastExit.transform.position * movementSpeed);
            this.isMoving = true;
            
        }
        if (Input.GetKeyDown(KeyCode.DownArrow) && this.isMoving == false)
        {
            this.rb.AddForce(this.westExit.transform.position * movementSpeed);
            this.isMoving = true;

        }
        if (Input.GetKeyDown(KeyCode.LeftArrow) && this.isMoving == false)
        {
            this.rb.AddForce(this.southExit.transform.position * movementSpeed);
            this.isMoving = true;

        }

    }

    //this code will load the next scene in the event that the player collides with the exit
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Exit") && MasterData.isExiting)
        {
            if (other.gameObject == this.northExit)
            {
                MasterData.whereDidIComeFrom = "north";
            }
            else if (other.gameObject == this.southExit)
            {
                MasterData.whereDidIComeFrom = "south";
            }
            else if (other.gameObject == this.eastExit)
            {
                MasterData.whereDidIComeFrom = "east";
            }
            else if (other.gameObject == this.westExit)
            {
                MasterData.whereDidIComeFrom = "west";
            }
            MasterData.isExiting = false;
            SceneManager.LoadScene("DungeonRoom");
        }
        else if(other.gameObject.CompareTag("Exit") && !MasterData.isExiting)
        {
            MasterData.isExiting = true;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("center"))
        {
            SceneManager.LoadScene("DungeonRoom");
        }
    }

    /*private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("center"))
        {
            this.rb.velocity = Vector3.zero;
            this.rb.isKinematic = true;
        }

    }*/
}



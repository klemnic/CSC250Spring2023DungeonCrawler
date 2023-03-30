using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DungeonSetUp : MonoBehaviour
{
    public GameObject northExit;
    public GameObject southExit;
    public GameObject eastExit;
    public GameObject westExit;

    public bool northOn = false;
    public bool southOn = true;
    public bool eastOn = true;
    public bool westOn = true;

    // Start is called before the first frame update
    void Start()
    {
        //hw answer should be in here!
        if (northOn = true)
        {
            northExit.SetActive(true);
        }
        else
        {
            northExit.SetActive(false);
        }

        if (southOn = true)
        {
            southExit.SetActive(true);
        }
        else
        {
            southExit.SetActive(false);
        }

        if (eastOn = true)
        {
            eastExit.SetActive(true);
        }
        else
        {
            eastExit.SetActive(false);
        }

        if (westOn = true)
        {
            westExit.SetActive(true);
        }
        else
        {
            westExit.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

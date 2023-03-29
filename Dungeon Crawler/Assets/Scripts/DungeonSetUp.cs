using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DungeonSetUp : MonoBehaviour
{
    public GameObject northExit;
    public GameObject southExit;
    public GameObject eastExit;
    public GameObject westExit;

    public bool northOn;
    public bool southOn;
    public bool eastOn;
    public bool westOn;

    // Start is called before the first frame update
    void Start()
    {
        this.northExit.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

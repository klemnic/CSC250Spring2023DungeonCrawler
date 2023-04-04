using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CenterPoint : MonoBehaviour
{
    public GameObject thePlayer;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == this.thePlayer)
        {
            SceneManager.LoadScene("DungeonRoom");
        }
    }
}

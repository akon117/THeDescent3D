using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPosition : MonoBehaviour
{
    public GameObject player;
    bool check;

    public void firstLevel()
    {

        if (GameObject.Find("GameManager").GetComponent<GameManager>().returning == true)
        {
            player.transform.SetPositionAndRotation(new Vector3(-31.91f, 0.62f, -61.96f), new Quaternion(0, 0, 0, 0));
            GameObject.Find("GameManager").GetComponent<GameManager>().returning = false;

        }
    }

    public void secondLevel()
    {
        Debug.Log("Test");

        player.transform.SetPositionAndRotation(new Vector3(7.614f, 0.1f, 2.253f), new Quaternion(0, 0, 0, 0));
        GameObject.Find("GameManager").GetComponent<GameManager>().returning = true;

    }

    
}

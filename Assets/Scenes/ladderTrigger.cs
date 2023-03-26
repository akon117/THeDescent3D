using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;



public class ladderTrigger : MonoBehaviour
{
    public TextMeshProUGUI UItext;
    public gameManager pipManager;

    private bool playerInRange;
    // Start is called before the first frame update
    void Start()
    {
        playerInRange = false;
        UItext.text = "";
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "Player" && GameObject.Find("pipManager").GetComponent<gameManager>().miniGameCompleted)
        {
            UItext.text = "press E to Ascend";
            playerInRange = true;
            Debug.Log("player enter");
        }
    }

    private void OnTriggerExit(Collider collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            UItext.text = "";
            playerInRange = false;
            Debug.Log("player exit");
        }
    }
}

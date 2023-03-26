using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Ascend : MonoBehaviour
{
    public Camera mainCamera;
    public GameObject player;
    public TextMeshProUGUI ascendText;
    public int check = 0;

    private bool playerInRange;

    

    void Start()
    {
        playerInRange = false;
        ascendText.text = "";
        
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && playerInRange == true)
        {
            ascendText.text = "";
            check++;
            if(check == 1)
            {
                player.GetComponent<Movement>().enabled = false;
                mainCamera.GetComponent<CameraFadeOut>().fadeOut = true;
                StartCoroutine(LoadLadder());
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            playerInRange = true;
            ascendText.text = "Press 'E' to Ascend";
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            playerInRange = false;
            ascendText.text = "";
        }
    }

    IEnumerator LoadLadder()
    {
        GameObject.Find("GameManager").GetComponent<LevelTracker>().level = 1;
        yield return new WaitForSeconds(5);
        GameObject.Find("GameManager").GetComponent<LoadNextScene>().LoadScene("Ladder");
    }

}

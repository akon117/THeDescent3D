using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class BoatTrigger : MonoBehaviour
{
    [Header("Visual Cue")]
    [SerializeField] private GameObject visualCue;

    public GameObject pipMiniGame;

    private bool playerInRange;
    public gameManager pipManager;

    public bool BoatTaskDone = false;

    private bool ending;
    public GameObject endScene;

    public TextMeshProUGUI UItext;

    private void Awake()
    {
        if(pipManager.miniGameCompleted)
        {
            pipManager.miniGameCompleted = false;
        }

        playerInRange = false;
        UItext.text = "";
    }

    private void Update()
    {
        if (playerInRange)
        {
            //visualCue.SetActive(true);
            //UItext.text = "press E to interact";
            if (Input.GetKeyDown(KeyCode.E)) //<---InputManager.GetInstance().GetInteractPressed()
            {
                UItext.text = "";
                Debug.Log("Boat button pressed!");
                if(pipManager.miniGameCompleted == false){
                    pipMiniGame.SetActive(true);
                    //GameObject.Find("Main Camera").GetComponent<CameraFollow>().yOffset = 2.5f;
                }
                else{
                    //continue level
                    if(SceneManager.GetActiveScene().name == "SampleScene")
                    {
                        Debug.Log("SampleScene");
                        //StartCoroutine(changeScenes());
                    }
                    if(SceneManager.GetActiveScene().name == "ShipInterior")
                    {   
                        
                    }

                    
                }
                
            }
        }
        else
        {
            //visualCue.SetActive(false);
        }
    }

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "Player" && !GameObject.Find("pipManager").GetComponent<gameManager>().miniGameCompleted)
        {
            UItext.text = "press E to interact";
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

    // IEnumerator changeScenes()
    // {
    //     yield return new WaitForSeconds(5);
    //     GameObject.Find("SceneManager").GetComponent<LoadNextScene>().LoadScene(1);
    // }
}

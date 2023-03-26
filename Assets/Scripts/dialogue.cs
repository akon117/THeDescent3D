using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class dialogue : MonoBehaviour
{
    public TextAsset currentJson;

    public TextAsset inkJson1;
    public TextAsset inkJson2;
    public TextAsset inkJson3;
    public TextAsset inkJson4;
    public TextAsset inkJson5;

    public GameObject Whale;
    public GameObject Shark;
    public GameObject Squid;

    public GameObject gameManager;
    //public int encounter;
    //public GameObject computer;

    // Start is called before the first frame update
    void Start()
    {
        
        
    }

    // Update is called once per frame
    void Update()
    {

        if (gameManager.GetComponent<LevelTracker>().level == 1)
        {
            //GameObject.Find("computer").GetComponent<DialogueTrigger>().SetInkJson(inkJson1);
            currentJson = inkJson1;
        }
        if (gameManager.GetComponent<LevelTracker>().level == 2)
        {
            //GameObject.Find("computer").GetComponent<DialogueTrigger>().SetInkJson(inkJson2);
            currentJson = inkJson2;
            if (SceneManager.GetActiveScene().name == "SampleScene")
            {
                Whale.SetActive(true);
                Shark.SetActive(false);
                Squid.SetActive(false);
            }
        }
        if (gameManager.GetComponent<LevelTracker>().level == 3)
        {
            //GameObject.Find("computer").GetComponent<DialogueTrigger>().SetInkJson(inkJson3);
            currentJson = inkJson3;
            if (SceneManager.GetActiveScene().name == "SampleScene")
            {
                Shark.SetActive(true);
                Whale.SetActive(false);
                Squid.SetActive(false);
            }
        }
        if (gameManager.GetComponent<LevelTracker>().level == 4)
        {
            //GameObject.Find("computer").GetComponent<DialogueTrigger>().SetInkJson(inkJson4);
            currentJson = inkJson4;
            if (SceneManager.GetActiveScene().name == "SampleScene")
            {
                Squid.SetActive(true);
                Shark.SetActive(false);
                Whale.SetActive(false);
            }
        }
        if (gameManager.GetComponent<LevelTracker>().level == 5)
        {
            //GameObject.Find("computer").GetComponent<DialogueTrigger>().SetInkJson(inkJson5);
            currentJson = inkJson5;
            Squid.SetActive(false);
            Shark.SetActive(false);
            Whale.SetActive(false);
        }
    }
}

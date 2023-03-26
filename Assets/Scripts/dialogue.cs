using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dialogue : MonoBehaviour
{
    public TextAsset inkJson1;
    public TextAsset inkJson2;
    public TextAsset inkJson3;
    public TextAsset inkJson4;
    public TextAsset inkJson5;

    public int encounter;
    //public GameObject computer;

    // Start is called before the first frame update
    void Start()
    {
        if(encounter == 1){
            GameObject.Find("computer").GetComponent<DialogueTrigger>().SetInkJson(inkJson1);
        }
        if(encounter == 2){
            GameObject.Find("computer").GetComponent<DialogueTrigger>().SetInkJson(inkJson2);
        }
        if(encounter == 3){
            GameObject.Find("computer").GetComponent<DialogueTrigger>().SetInkJson(inkJson3);
        }
        if(encounter == 4){
            GameObject.Find("computer").GetComponent<DialogueTrigger>().SetInkJson(inkJson4);
        }
        if(encounter == 5){
            GameObject.Find("computer").GetComponent<DialogueTrigger>().SetInkJson(inkJson5);
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

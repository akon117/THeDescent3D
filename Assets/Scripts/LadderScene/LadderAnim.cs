using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LadderAnim : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(ReturnToSub());
    }


    IEnumerator ReturnToSub()
    {
        yield return new WaitForSeconds(5);
        GameObject.Find("GameManager").GetComponent<LoadNextScene>().LoadScene("Level2");
    }
}

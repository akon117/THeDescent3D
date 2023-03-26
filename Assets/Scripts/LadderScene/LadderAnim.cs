using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LadderAnim : MonoBehaviour
{
    public GameObject ladder;

    // Start is called before the first frame update
    void Start()
    {
        if (GameObject.Find("GameManager").GetComponent<LevelTracker>().level == 2)
        {
            StartCoroutine(ReturnToSub1());
        }
        else
        {
            StartCoroutine(ReturnToSub2());
        }
    }


    IEnumerator ReturnToSub1()
    {
        yield return new WaitForSeconds(2);
        LeanTween.scale(ladder, new Vector3(100, 100, 100), 1f).setEase(LeanTweenType.easeInExpo).setDelay(1f);
        GameObject.Find("Main Camera").GetComponent<CameraFadeOut>().fadeOut = true;
        yield return new WaitForSeconds(2);
        for (int i = 0; i < 5; i++)
        {
            LeanTween.moveY(ladder, 5, 5f);
        }
        Debug.Log("Test");
        yield return new WaitForSeconds(5);
        GameObject.Find("GameManager").GetComponent<LoadNextScene>().LoadScene("Level2");
    }

    IEnumerator ReturnToSub2()
    {
        
        LeanTween.scale(ladder, new Vector3(100, 200, 100), 1f).setEase(LeanTweenType.easeInExpo).setDelay(1f);
        GameObject.Find("Main Camera").GetComponent<CameraFadeOut>().fadeOut = true;
        yield return new WaitForSeconds(2);
        for (int i = 0; i < 5; i++)
        {
            LeanTween.moveY(ladder, 500, 5f);
        }
        yield return new WaitForSeconds(5);
        Debug.Log("Test");
        GameObject.Find("GameManager").GetComponent<LoadNextScene>().LoadScene("Level2");
    }
}

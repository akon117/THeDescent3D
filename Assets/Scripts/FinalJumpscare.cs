using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinalJumpscare : MonoBehaviour
{
    public GameObject eyes;
    public GameObject panel;

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player" && GameObject.Find("GameManager").GetComponent<LevelTracker>().level == 5)
        {
            other.GetComponent<Movement>().enabled = false;
            other.GetComponent<Rigidbody>().isKinematic = true;
            other.GetComponent<Animator>().SetBool("Backwards", false);
            other.GetComponent<Animator>().SetFloat("Speed", 0);
            GameObject.Find("SubNoise").GetComponent<AudioSource>().Stop();
            GameObject.Find("OceanNoise").GetComponent<AudioSource>().Stop();
            StartCoroutine(Jumpscare());
        }
    }

    IEnumerator Jumpscare()
    {
        yield return new WaitForSeconds(3);
        GameObject.Find("JumpscareNoise").GetComponent<AudioSource>().Play();
        eyes.SetActive(true);
        yield return new WaitForSeconds(0.5f);
        panel.SetActive(true);
        yield return new WaitForSeconds(3);
        GameObject.Find("GameManager").GetComponent<LoadNextScene>().LoadScene("Credits");
    }
}

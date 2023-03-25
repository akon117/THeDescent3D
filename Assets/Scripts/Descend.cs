using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Descend : MonoBehaviour
{
    public TextMeshProUGUI descendText;

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            descendText.enabled = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            descendText.enabled = false;
        }
    }
}

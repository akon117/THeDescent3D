using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public bool returning = false;

    private void Start()
    {
        returning = false;
    }


    public void GoToLadder()
    {
        returning = false;
    }

    public void returnFromLadder()
    {
        returning = true;
    }

}

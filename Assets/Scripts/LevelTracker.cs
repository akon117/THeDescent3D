using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelTracker : MonoBehaviour
{
    public int level;
    public int floor;

    private void Start()
    {
        level = 1;
        floor = 1;
    }
}

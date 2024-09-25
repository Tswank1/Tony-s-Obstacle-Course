using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{
    public float timeTaken { get; private set; } 

    void Update()
    {
        timeTaken += Time.deltaTime;
    }
}

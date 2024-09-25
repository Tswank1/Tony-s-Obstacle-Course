using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class laserSpinner : MonoBehaviour
{
    [SerializeField] private float rotationSpeed = 200;
    void Update()
    {
        transform.Rotate(0, rotationSpeed * Time.deltaTime, 0);
    }
}

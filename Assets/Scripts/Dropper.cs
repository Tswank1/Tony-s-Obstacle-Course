using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dropper : MonoBehaviour
{
    [SerializeField] private GameObject droppedGO;
    private float spawnedTime = 0;

    void Update()
    {
        float checkTime = Time.time - spawnedTime;
        if(checkTime >= 3)
        {
            spawnedTime = Time.time;
            Instantiate(droppedGO, transform.position, Quaternion.identity);
        }
    }

    //How prof is doing it
    /*
    private MeshRenderer mr;
    private Rigidbody rb;

    private float spawnedTime = 0;

    void Start()
    {
        mr = GetComponent<MeshRenderer>;
        rb = GetComponent<Rigidbody>;

        mr?.enabled = false;
        rb?.useGravity = false;
    }

    void Update()
    {
        float checkTime = Time.time - spawnedTime;
        if(checkTime >= 3)
        {
            spawnedTime = Time.time;
            mr?.enabled = true;
            rb?.useGravity = true;
        }
    }

    */
}

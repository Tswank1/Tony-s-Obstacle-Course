using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class laserMover : MonoBehaviour
{
    [SerializeField] private float moveSpeed;
    [SerializeField] private Transform target;
    private Vector3 startPosition;
    [SerializeField] private float threshold = 1;
    [SerializeField] private float offsetTime;
    private bool canStart = false;

    [Header("DEBUG")]
        [SerializeField] private bool swapDir = false;

    void Start()
    {
        startPosition = transform.position;

        StartCoroutine(OffSet(offsetTime));
    }

    private IEnumerator OffSet(float offset)
    {
        yield return new WaitForSeconds(offset);
        canStart = true;
    }

    void Update()
    {
        if (!canStart)
            return;

        if(!swapDir)
            transform.position = Vector3.MoveTowards(transform.position, target.position, moveSpeed * Time.deltaTime);
        else
            transform.position = Vector3.MoveTowards(transform.position, startPosition, moveSpeed * Time.deltaTime);


        if (Vector3.Distance(transform.position, target.position) < threshold)
        {
            swapDir = true;
        }
        else if (Vector3.Distance(transform.position, startPosition) < threshold)
        {
            swapDir = false;
        }
    }
}

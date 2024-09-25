using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOnGround : MonoBehaviour
{
    [SerializeField] private LayerMask groundLayer;

    private void OnTriggerEnter(Collider other)
    {
        if ((groundLayer.value & (1 << other.gameObject.layer)) == 0)
            return;

        Destroy(gameObject);
    }
}

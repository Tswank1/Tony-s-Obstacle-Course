using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinCondition : MonoBehaviour
{
    [SerializeField] private LayerMask player;
    public GameObject winScreen;

    void Start()
    {
        winScreen?.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        if ((player.value & (1 << other.gameObject.layer)) == 0) 
            return;

        winScreen?.SetActive(true);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DisplayNumHit : MonoBehaviour
{
    [SerializeField] private ObjectHit player;
    private TMP_Text objText;

    void Awake()
    {
        objText = GetComponent<TMP_Text>();
        objText.text = player.numberOfObjectsHit.ToString();
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DisplayTime : MonoBehaviour
{
    [SerializeField] private Timer player;
    private TMP_Text objText;

    void Awake()
    {
        objText = GetComponent<TMP_Text>();
        objText.text = player.timeTaken.ToString("0.00");
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerTransformMovement : MonoBehaviour
{
    private Vector3 MoveDir;
    [SerializeField] private float MoveSpeed = 1;

    private void Update()
    {
        GetInput();
        transform.Translate(MoveDir * MoveSpeed * Time.deltaTime);
    }

    private void GetInput()
    {
        MoveDir.x = Input.GetAxis("Horizontal");
        MoveDir.z = Input.GetAxis("Vertical");
    }
}

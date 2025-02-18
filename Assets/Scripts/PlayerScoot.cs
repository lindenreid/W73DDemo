using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScoot : MonoBehaviour
{
    [SerializeField] private float _speed = 1.0f;

    // movement
    private void Update ()
    {
        Vector3 direction = Vector3.zero;

        if(Input.GetKey(KeyCode.W))
        {
            direction += Vector3.forward;
        }

        if (Input.GetKey(KeyCode.A))
        {
            direction += Vector3.left;
        }

        if (Input.GetKey(KeyCode.S))
        {
            direction += Vector3.back;
        }

        if (Input.GetKey(KeyCode.D))
        {
            direction += Vector3.right;
        }

        transform.Translate(direction * _speed * Time.deltaTime);
    }
}
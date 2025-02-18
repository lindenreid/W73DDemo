using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSimple : MonoBehaviour
{
    private void Update ()
    {
        Vector3 direction = new Vector3(1, 0, 1);
        direction -= new Vector3(1, 0, 2);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            transform.position += direction;
        }
    }
}
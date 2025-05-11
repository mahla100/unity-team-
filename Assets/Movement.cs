using System.Collections;
using System.Collections.Generic;
using System.Timers;
using UnityEngine;

public class Movement : MonoBehaviour
{

    void Update()
    {
        if (Input.GetKey(KeyCode.D))
        {
            transform.position += new Vector3(0.05f, 0, 0);

        }
        else if (Input.GetKey(KeyCode.A))
        {
            transform.position += new Vector3(-0.05f, 0, 0);
        }

    }
}

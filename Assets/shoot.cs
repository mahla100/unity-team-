using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shoot : MonoBehaviour
{
    public GameObject bullet;
    public Transform Firepoint;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
          if (Input .GetKeyDown(KeyCode.Space))
   {
            Instantiate(bullet, Firepoint.position, Firepoint.rotation)
                .GetComponent<Rigidbody>().velocity = Firepoint.forward * 20f;
         }
        }
    }


using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;
using UnityEngine;

public class enemy : MonoBehaviour
{
    public GameObject gm;
    public Transform tf;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftShift))
        {
            Instantiate(gm, new Vector3(Random.Range(-10, 10), Random.Range(-20, 20), 6), tf.rotation);
        }
     }
        
}

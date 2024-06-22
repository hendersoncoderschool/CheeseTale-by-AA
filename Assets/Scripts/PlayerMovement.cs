using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("w"))
        {
            transform.Translate(transform.up * speed * Time.deltaTime);
        }

        if (Input.GetKey("s"))
        {
            transform.Translate(-transform.up * speed * Time.deltaTime);
        }

        if (Input.GetKey("a"))
        {
            transform.Translate(-transform.right * speed * Time.deltaTime);
        }

        if (Input.GetKey("d"))
        {
            transform.Translate(transform.right * speed * Time.deltaTime);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed;
    private Animator animator;
    private string direction = ""; 
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("w"))
        {
            if (direction != "up")
            {
                animator.SetTrigger("up");
                direction = "up";
            }

            transform.Translate(transform.up * speed * Time.deltaTime);
        }

        if (Input.GetKey("s"))
        {
            if(direction != "down")
            {
                animator.SetTrigger("down");
                direction = "down";
            }
            
            transform.Translate(-transform.up * speed * Time.deltaTime);
                
        }

        if (Input.GetKey("a"))
        {
            if (direction != "left")
            {
                animator.SetTrigger("left");
                direction = "left";
            }
            transform.Translate(-transform.right * speed * Time.deltaTime);
        }

        if (Input.GetKey("d"))
        {
            if (direction != "right")
            {
                animator.SetTrigger("right");
                direction = "right";
            }
            transform.Translate(transform.right * speed * Time.deltaTime);
        }

        if (Input.GetKeyUp("w") ||  Input.GetKeyUp("a") ||  Input.GetKeyUp("s") || Input.GetKeyUp("d")){
            animator.SetTrigger("idle");
            direction = "";
        }
    }
}

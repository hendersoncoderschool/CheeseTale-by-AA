using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class PlayerMovement : MonoBehaviour
{
    public float speed;
    private Animator animator;
    private Rigidbody2D rb;
    private string direction = ""; 

    private float horizontal;
    private float vertical;

    private Vector2 movement;
    private bool isWalking = true;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        animator.SetFloat("move x",movement.x);
        animator.SetFloat("move y",movement.y);

        if (movement.x==0f && movement.y==0f && isWalking == true){
            isWalking = false;
            animator.SetBool("is walking",false);
            animator.SetFloat("prev move x",movement.x);
            animator.SetFloat("prev move y",movement.y);
        }
        else {
            isWalking = true;
            animator.SetBool("is walking",true);
        }
    }

    void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * speed * Time.fixedDeltaTime);
    }

    void OnTriggerEnter2d(Collider2D col){
        SceneManager.LoadScene("Tutorial Room");
    }
    
}

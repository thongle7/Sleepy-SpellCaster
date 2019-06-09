using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public float Speed = 0;//Don't touch this
    public float MaxSpeed;//This is the maximum speed that the object will achieve
    public float Acceleration;//How fast will object reach a maximum speed
    public Animator animator;

    // Use this for initialization
    void Start()
    {
        animator.SetFloat("speedRight", 1.0f);
        animator.SetBool("isFacingRight", true);
    }
    

    // Update is called once per frame
    void Update()
    {
        if (mon_control.monsterDefeated)
        {
            Destroy(Boomerangfly.CombatMonster);
            Destroy(Boomerangfly_Tutorial.CombatMonster);
            mon_control.monsterDefeated = false;
        }
        
        if (GameTime.isPaused) return;
        Movement();

        //Flip Sprite
        if (Input.GetAxisRaw("Horizontal") > 0)
        {
            animator.SetFloat("speedRight", 1.0f);
            animator.SetBool("isFacingRight", true);
        }
        else
        {
            animator.SetFloat("speedRight", -1.0f);
        }

        if (Input.GetAxisRaw("Horizontal") < 0)
        {
            animator.SetFloat("speedLeft", 1.0f);
            animator.SetBool("isFacingRight", false);
        }
        else
        {
            animator.SetFloat("speedLeft", -1.0f);
        }
    }

    void Movement()
    {
        Vector3 p = new Vector3();

        if (Input.GetKey(KeyCode.A) && Input.GetKey(KeyCode.D))
        {
            Speed = 0;
        }
        else if (!Input.GetKey(KeyCode.A) && !Input.GetKey(KeyCode.D))
        {
            Speed = 0;
        }
        else if (Input.GetKey(KeyCode.A) && Speed > 0)
        {
            Speed = 0;
        }
        else if (Input.GetKey(KeyCode.D) && Speed < 0)
        {
            Speed = 0;
        }
        else if (Input.GetKey(KeyCode.A) && Speed > -MaxSpeed)
        {
            Speed = Speed - (Acceleration * Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.D) && Speed < MaxSpeed)
        {
            Speed = Speed + (Acceleration * Time.deltaTime);
        }
        else
        {
            if (Speed > 0)
            {
                Speed = MaxSpeed;
            }
            else
            {
                Speed = -MaxSpeed;
            }
        }

        p.x = transform.position.x + (Speed * Time.deltaTime);
        p.y = transform.position.y;
        transform.position = p;
    }


    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.CompareTag("Platform") && col.gameObject.name != "Wall")
        {
            animator.SetBool("isTouchingGround", true);
        }
    }

    void OnCollisionStay2D(Collision2D col)
    {
        if (col.gameObject.CompareTag("Platform") && col.gameObject.name != "Wall")
        {
            animator.SetBool("isTouchingGround", true);
        }
    }


    void OnCollisionExit2D(Collision2D col)
    {
        animator.SetBool("isTouchingGround", false);
    }


}

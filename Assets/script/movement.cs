using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class movement : MonoBehaviour
{
    //déplacement
    public float speed;
    public Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        speed = 3f;
    }

    void FixedUpdate()
    {
        move();
    }

    void move()
    {
        GameObject.Find("Player").transform.localEulerAngles = new Vector3(0.0f, 0.0f, 0.0f);
        if (Input.GetKey(KeyCode.Q))
        {
            animator.SetBool("attack", false);
            animator.SetBool("up", false);
            animator.SetBool("down", false);
            animator.SetBool("right", false);
            animator.SetBool("left", true);
            animator.SetBool("idle", false);
            GameObject.Find("Light").transform.localEulerAngles = new Vector3(0.0f, 0.0f, -270.0f);
            transform.position -= new Vector3(speed * Time.deltaTime, 0.0f, 0.0f);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            animator.SetBool("attack", false);
            animator.SetBool("up", false);
            animator.SetBool("down", false); 
            animator.SetBool("right", true);
            animator.SetBool("left", false);    
            animator.SetBool("idle", false);
            GameObject.Find("Light").transform.localEulerAngles = new Vector3(0.0f, 0.0f, -89.0f);
            transform.position += new Vector3(speed * Time.deltaTime, 0.0f, 0.0f);
        }
        else if (Input.GetKey(KeyCode.S))
        {
            animator.SetBool("attack", false);
            animator.SetBool("up", false);
            animator.SetBool("down", true); 
            animator.SetBool("right", false);
            animator.SetBool("left", false);
            animator.SetBool("idle", false);
            GameObject.Find("Light").transform.localEulerAngles = new Vector3(0.0f, 0.0f, -180.0f);
            transform.position -= new Vector3(0.0f, speed * Time.deltaTime, 0.0f);
        }
        else if (Input.GetKey(KeyCode.Z))
        {
            animator.SetBool("attack", false);
            animator.SetBool("up", true);
            animator.SetBool("idle", false);
            animator.SetBool("down", false);
            animator.SetBool("right", false);
            animator.SetBool("left", false);
            GameObject.Find("Light").transform.localEulerAngles = new Vector3(0.0f, 0.0f, 0.0f);
            transform.position += new Vector3(0.0f, speed * Time.deltaTime, 0.0f);
        }
        else if (Input.GetKey(KeyCode.Space))
        {
            animator.SetTrigger("attack");
            animator.SetBool("up", false);
            animator.SetBool("down", false);
            animator.SetBool("right", false);
            animator.SetBool("left", false);
            animator.SetBool("idle", false);
        }
        else
        {
                animator.SetBool("up", false);
                animator.SetBool("down", false);
                animator.SetBool("right", false);
                animator.SetBool("left", false);
                animator.SetBool("idle", true);
        }

        //manette
       /* if (Input.GetAxis("Horizontal") == -1 && !left)
        {
            animator.SetBool("left", true);
            GameObject.Find("Player").GetComponent<SpriteRenderer>().flipX = true;
            transform.position -= new Vector3(speed * Time.deltaTime, 0.0f, 0.0f);
        }
        if (Input.GetAxis("Horizontal") == 1 && !right)
        {
            animator.SetBool("right", true);
            GameObject.Find("Player").GetComponent<SpriteRenderer>().flipX = false;
            transform.position += new Vector3(speed * Time.deltaTime, 0.0f, 0.0f);
        }
        if (Input.GetAxis("Vertical") == -1 && !down)
        {
            animator.SetBool("down", true);
            transform.position -= new Vector3(0.0f, speed * Time.deltaTime, 0.0f);
        }
        if (Input.GetAxis("Vertical") == 1 && !up)
        {
            animator.SetBool("up", true);
            transform.position += new Vector3(0.0f, speed * Time.deltaTime, 0.0f);
        }*/
    }

    // Update is called once per frame
    void Update()
    {
       
    }
}

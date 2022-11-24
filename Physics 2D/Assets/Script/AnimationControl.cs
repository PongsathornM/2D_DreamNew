using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class AnimationControl : MonoBehaviour
{
    private Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        animator = gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        /*
        if (Input.GetKeyDown(KeyCode.A))
        {
            animator.SetBool("Run", true);
        }
        else if (Input.GetKeyDown(KeyCode.D))
        {
            animator.SetBool("Run",true);
        }
        else
        {
            animator.SetBool("Run",false);
        }
        */
         //animator
         //animator.SetBool("Run", hor);
    }
}

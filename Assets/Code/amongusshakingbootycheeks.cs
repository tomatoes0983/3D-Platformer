using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class amongusshakingbootycheeks : MonoBehaviour
{
    public Animator animator;
    void Update()
    {
        animator.SetFloat("vx", Input.GetAxis("Horizontal"),0.1f, Time.deltaTime);
        animator.SetFloat("vy", Input.GetAxis("Verical"), 0.1f, Time.deltaTime);
    }
}

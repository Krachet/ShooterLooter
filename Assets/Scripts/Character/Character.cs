using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    //Animation
    public Animator animator;
    public enum AnimationState
    {
        Idle,
        Run,
        Attack,
        Dead
    }

    public void ChangeState(AnimationState newAnimationState)
    {
        switch (newAnimationState)
        {
            case AnimationState.Idle:
                animator.SetBool("Idling", true);
                animator.SetBool("Running", false);
                break;

            case AnimationState.Run:
                animator.SetBool("Idling", false);
                animator.SetBool("Running", true);
                break;

            default:
                break;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationEnemy : MonoBehaviour
{
    public static AnimationEnemy animationEnemy;

    enum AnimationVariables
    {
        isDead
    }


    private void Awake()
    {
        animationEnemy = this;
    }

    public void SetDeadEnemy(Animator animator)
    {
        print("anim = " + AnimationVariables.isDead.ToString());
        animator.SetBool(AnimationVariables.isDead.ToString(), true);
    }
}

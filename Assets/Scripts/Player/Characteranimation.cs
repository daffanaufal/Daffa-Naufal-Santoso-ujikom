using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Characteranimation : MonoBehaviour
{
    private Animator anim;

    private void Awake()
    {
        anim = GetComponent<Animator>();
    }

    public void lempar()
    {
        anim.SetTrigger(Animationtags.lempar);
    }public void left()
    {
        anim.SetTrigger(Animationtags.left);
    }
    public void right()
    {
        anim.SetTrigger(Animationtags.right);
    }

}

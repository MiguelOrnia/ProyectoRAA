using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DanceMoves : MonoBehaviour {

    public GameObject rocky;
    private Animator animator;

    void Start()
    {
        animator = rocky.GetComponent<Animator> ();
    }

    public void Animacion1()
    {
        animator.SetTrigger("animacion1");
    }

    public void Animacion2()
    {
        animator.SetTrigger("animacion2");
    }

}

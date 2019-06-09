using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterAttributes : MonoBehaviour {
    
    public  float healthIn;
    public  float damageIn;
    public Animator animator;
    private Patrol patrol;

    void Start()
    {
        patrol = this.GetComponent<Patrol>();
        if(patrol)
        {
            animator.SetBool("hasPatrol", true);
        }
    }
    
}

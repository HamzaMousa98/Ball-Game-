using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class MovmentBallFair : MovmentThing
{
    void Start()
    {
        move_ = true;
        navMesh_ = GetComponent<NavMeshAgent>();
    }
    void Update()
    {
        this.Movement2();
    }
    
}

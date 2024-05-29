using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;
using UnityEngine;
using UnityEngine.AI;

public class MovmentIceBall : MovmentThing
{
    private void Start()
    {
        move_ = true;
        navMesh_ = GetComponent<NavMeshAgent>();
    }
    private void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.tag.Equals("Ball"))
        {
            this.Movement1();
        }
    }
    private void Update()
    {
       
        
    }
}

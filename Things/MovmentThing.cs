using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class MovmentThing : MonoBehaviour
{
    private NavMeshAgent navMesh;
    public NavMeshAgent navMesh_
    {
        get { return navMesh; }
        set { navMesh = value; }
    }
    private bool move;
    public bool move_
    {
        get { return move; }
        set { move = value; }
    }
    public GameObject Point1;
    public GameObject Point2;
    void Start()
    {
        
    }
    void Update()
    {
        
    }
    public void Movement1()
    {

        if (move)
        {
            navMesh.SetDestination(Point2.transform.position);
        }
        else navMesh.SetDestination(Point1.transform.position);


        if (navMesh.transform.position == Point2.transform.position)
            move = false;
        else if (navMesh.transform.position == Point1.transform.position)
            move = true;

    }
    public void Movement2()
    {
           if(move)
            navMesh.SetDestination(Point1.transform.position);
    }
   

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class MovmentCube : MonoBehaviour
{
    public float maxMove;
    public float speed;
    private bool move;
    public int TyoeMove;
    private int count;

    void Start()
    {
        if(speed.Equals(0))
        speed = 0.02f;
        count = 0;
        move = true;
    }
  
    void Update()
    {
        if (TyoeMove == 1)
            upFirst();
        else if (TyoeMove == 2)
            UpLast();
        else if (TyoeMove == 3)
            LeftToRight();
        else if (TyoeMove == 4)
            RightToLeft();
    }
    public void upFirst()
    {
        if (count >= maxMove)
        {
            move = false;
        }
        else if (count <= 0)
        {
            move = true;
        }
        if (move)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y + speed, transform.position.z);
            count++;
        }
        else
        {
            transform.position = new Vector3(transform.position.x, transform.position.y - speed, transform.position.z);
            count--;
        }
    }
    public void UpLast()
    {
        if (count >= maxMove)
        {
            move = false;
        }
        else if (count <= 0)
        {
            move = true;
        }
        if (move)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y - speed, transform.position.z);
            count++;
        }
        else
        {
            transform.position = new Vector3(transform.position.x, transform.position.y + speed, transform.position.z);
            count--;
        }
    }
    public void LeftToRight()
    {
        if (count >= maxMove)
        {
            move = false;
        }
        else if (count <= 0)
        {
            move = true;
        }
        if (move)
        {
            transform.position = new Vector3(transform.position.x , transform.position.y , transform.position.z + speed);
            count++;
        }
        else
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z - speed);
            count--;
        }
    }
    public void RightToLeft()
    {
        if (count >= maxMove)
        {
            move = false;
        }
        else if (count <= 0)
        {
            move = true;
        }
        if (move)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z - speed);
            count++;
        }
        else
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z + speed);
            count--;
        }
    }
}

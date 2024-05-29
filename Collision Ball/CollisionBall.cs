using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CollisionBall : MonoBehaviour
{
    public GameObject liquid;
    public GameObject Solid;
    public GameObject Gas;
    private ChangeBall changeBall;
    public ChangeBall changeBall_
    {
        get
        {
            return changeBall;
        }
        set
        {
            changeBall = value;
        }
    }
    private GlassBall GlassBall;
    public GlassBall GlassBall_
    {
        get
        {
            return GlassBall;
        }
        set
        {
            GlassBall = value;
        }
    }
    private GameObject Water;
    public GameObject Water_
    {
        get
        {
            return Water;
        }
        set
        {
            Water = value;
        }
    }
    private Time LongEffict;
    public Time LongEffict_
    {
        get
        {
            return LongEffict;
        }
        set
        {
            LongEffict = value;
        }
    }
    private bool shockBall;

    public bool shockBall_
    {
        get
        {
            return shockBall;
        }
        set
        {
            shockBall = value;
        }
    }
    private void Start()
    {
        shockBall_ = false;
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (!collision.gameObject.tag.Equals("grounded"))
        {
            shockBall_ = true;
        }
    }
    private void OnCollisionExit(Collision collision)
    {
        if (!collision.gameObject.tag.Equals("grounded"))
        {
            shockBall_ = false;
        }
    }
}

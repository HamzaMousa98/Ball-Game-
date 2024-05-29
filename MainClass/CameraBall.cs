using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraBall : MonoBehaviour
{
    private GameObject ball;
    private void Start()
    {
        
    }
    void Update()
    {
        ball = GameObject.FindGameObjectWithTag("Ball");
        this.transform.position =  ball.transform.position;
    }
}

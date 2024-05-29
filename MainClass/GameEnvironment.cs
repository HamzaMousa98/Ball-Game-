
using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.PlayerLoop;
using UnityEngine.UI;


public class GameEnvironment : MonoBehaviour
{
    private GlassBall glassBall;
    private Image GlassSize;
    private Image Temp;
    public FixedJoystick joystick;
    public float moveSpeed;
    public float x,y,move,TypeMove;
    public GameObject r;
    public GameObject jumpButton, UpButton, DownButton;
    void Start()
    {
        glassBall = GameObject.Find("GlassBall").GetComponent<GlassBall>();
        GlassSize = GameObject.Find("GlassSizeWaterL").GetComponent<Image>();
        Temp = GameObject.Find("TemoColor").GetComponent<Image>();
        x = r.transform.position.x;
        y = r.transform.position.y;

    }

    // Update is called once per frame
    void Update()
    {
        GlassSize.fillAmount = (glassBall.SizeWaterL_ / 1.5f)/100;
        Temp.fillAmount = glassBall.temperatureWater_ / 100;
        TypeMove = glassBall.typeMove_;
        HealthConroller();

        MoveBall();
       

      

    }
    void HealthConroller()
    {
        Image h1 = GameObject.Find("H1").GetComponent<Image>();
        Image h2 = GameObject.Find("H2").GetComponent<Image>();
        Image h3 = GameObject.Find("H3").GetComponent<Image>();
        Image h4 = GameObject.Find("H4").GetComponent<Image>();
        Image h5 = GameObject.Find("H5").GetComponent<Image>();
        Image h6 = GameObject.Find("H6").GetComponent<Image>();
        Image h7 = GameObject.Find("H7").GetComponent<Image>();
        Image h8 = GameObject.Find("H8").GetComponent<Image>();

        int health = glassBall.maxHealth_;

        if(health == 0)
        {
            h1.enabled = false;
            h2.enabled = false;
            h3.enabled = false;
            h4.enabled = false;
            h5.enabled = false;
            h6.enabled = false;
            h7.enabled = false;
            h8.enabled = false;
        }
        else if (health == 1)
        {
            h1.enabled = true;
            h2.enabled = false;
            h3.enabled = false;
            h4.enabled = false;
            h5.enabled = false;
            h6.enabled = false;
            h7.enabled = false;
            h8.enabled = false;
        }
        else if (health == 2)
        {
            h1.enabled = true;
            h2.enabled = true;
            h3.enabled = false;
            h4.enabled = false;
            h5.enabled = false;
            h6.enabled = false;
            h7.enabled = false;
            h8.enabled = false;
        }
        else if (health == 3)
        {
            h1.enabled = true;
            h2.enabled = true;
            h3.enabled = true;
            h4.enabled = false;
            h5.enabled = false;
            h6.enabled = false;
            h7.enabled = false;
            h8.enabled = false;
        }
        else if (health == 4)
        {
            h1.enabled = true;
            h2.enabled = true;
            h3.enabled = true;
            h4.enabled = true;
            h5.enabled = false;
            h6.enabled = false;
            h7.enabled = false;
            h8.enabled = false;
        }
        else if (health == 5)
        {
            h1.enabled = true;
            h2.enabled = true;
            h3.enabled = true;
            h4.enabled = true;
            h5.enabled = true;
            h6.enabled = false;
            h7.enabled = false;
            h8.enabled = false;
        }
        else if (health == 6)
        {
            h1.enabled = true;
            h2.enabled = true;
            h3.enabled = true;
            h4.enabled = true;
            h5.enabled = true;
            h6.enabled = true;
            h7.enabled = false;
            h8.enabled = false;
        }
        else if (health == 7)
        {
            h1.enabled = true;
            h2.enabled = true;
            h3.enabled = true;
            h4.enabled = true;
            h5.enabled = true;
            h6.enabled = true;
            h7.enabled = true;
            h8.enabled = false;
        }
        else if (health == 8)
        {
            h1.enabled = true;
            h2.enabled = true;
            h3.enabled = true;
            h4.enabled = true;
            h5.enabled = true;
            h6.enabled = true;
            h7.enabled = true;
            h8.enabled = true;
        }
    }
    void MoveBall()
    {

        glassBall.GetComponent<Rigidbody>().mass = 0.5f + (0.4f - (glassBall.SizeWater_ * -1));
        moveSpeed = 8 - (glassBall.GetComponent<Rigidbody>().mass * 4);

       

        if (r.transform.position.x == x && r.transform.position.y == y)
            move = 2;
        else move = 1;



        if (move == 1)
            glassBall.GetComponent<Rigidbody>().velocity = new Vector3(joystick.Horizontal * moveSpeed, glassBall.GetComponent<Rigidbody>().velocity.y, joystick.Vertical * moveSpeed);
    
    }

    private void ChangeTypeButton()
    {
        if(glassBall.temperatureWater_ >= 100)
        {
            jumpButton.active = false;
            UpButton.active = true;
            DownButton.active = true;
        }
        else
        {
            jumpButton.active = true;
            UpButton.active = false;
            DownButton.active = false;
        }
    }
}

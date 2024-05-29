using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GlassBall : MonoBehaviour
{
    private float temperatureWater;
    private Vector3 position;
    private float SizeWater;
    private float speed;
    private float weight;
    private int maxHealth;
    private int typeMove;
    private Rigidbody rigidbody;
    private float jumpSpeed;
    private float jumpForce;
    private int jumps;
    private bool grounded;
    private int SizeWaterL;
    private SavePoint savePoint;



    //________________________________________________________________
    public SavePoint savePoint_
    {
        get { return savePoint; }
        set { savePoint = value; }
    }
    public float speed_
    {
        get { return speed; }
        set { speed = value; }
    }
    public float weight_
    {
        get { return weight; }
        set { weight = value; }
    }
    public int maxHealth_
    {
        get { return maxHealth; }
        set { maxHealth = value; }
    }
    public int typeMove_
    {
        get { return typeMove; }
        set { typeMove = value; }
    }
    public Rigidbody rigidbody_
    {
        get { return rigidbody; }
        set { rigidbody = value; }
    }
    public float jumpSpeed_
    {
        get { return jumpSpeed; }
        set { jumpSpeed = value; }
    }
    public float jumpForce_
    {
        get { return jumpForce; }
        set { jumpForce = value; }
    }
    public int jumps_
    {
        get { return jumps; }
        set { jumps = value; }
    }
    public bool grounded_
    {
        get { return grounded; }
        set { grounded = value; }
    }
    public float SizeWater_
    {
        get { return SizeWater; }
        set { SizeWater = value; }
    }
    public Vector3 position_
    {
        get { return position; }
        set { position = value; }
    }
    public float temperatureWater_
    {
        get { return temperatureWater; }
        set { temperatureWater = value; }
    }
    public int SizeWaterL_ {
        get { return SizeWaterL; }
        set { SizeWaterL = value; }
    }

    //________________________________________________________________
    public Text text , text2;
    void Start()
    {
        temperatureWater = 30;
        SizeWater = -0.15f;
        position = this.transform.position;
        speed = 200;
        maxHealth = 3;
        typeMove = 1;
        jumps = 2;
        grounded = true;
        jumpForce = 2.2f;
        jumpSpeed = 1;
        rigidbody = this.GetComponent<Rigidbody>();
        savePoint = GameObject.Find("SavePoint0").GetComponent<SavePoint>();
      

    }

    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Jump();
        }

        if (Input.GetKeyDown(KeyCode.LeftControl))
        {
            MoveDown();
        }
        text.text = (int)temperatureWater+"C";

        SizeWaterL = (int)(200 * (0.35f - (SizeWater * -1)));

        

        weight = 0.5f + (0.4f - (SizeWater * -1));
        rigidbody.mass = weight;

        text2.text = (int)(SizeWaterL/1.5f)+"%";
    }
    
  /*  public void MoveRight() { rigidbody.AddForce(Vector3.right * speed * Time.deltaTime);  }
    public void Moveleft() { rigidbody.AddForce(Vector3.left * speed * Time.deltaTime); }
    public void Moveforward() { rigidbody.AddForce(Vector3.forward * speed * Time.deltaTime); }
    public void MoveBack(){  rigidbody.AddForce(-Vector3.forward * speed * Time.deltaTime); }*/
    public void MoveUp() { rigidbody.AddForce(Vector3.up * speed * Time.deltaTime); }
    public void MoveDown() { rigidbody.AddForce(-Vector3.up * speed * Time.deltaTime); }
   /* public void MoveBall()
    {

        if (this.typeMove == 1)
        {


            if (Input.GetAxis("Horizontal") > 0)
            {
                MoveRight();
            }
            else if (Input.GetAxis("Horizontal") < 0)
            {
                Moveleft();
            }
            if (Input.GetAxis("Vertical") > 0)
            {
                Moveforward();
            }
            else if (Input.GetAxis("Vertical") < 0)
            {
                MoveBack();
            }
        }
        else if (this.typeMove == 2)
        {
            if (Input.GetAxis("Horizontal") > 0)
            {
                MoveRight();
            }
            else if (Input.GetAxis("Horizontal") < 0)
            {
                Moveleft();
            }
            if (Input.GetAxis("Vertical") > 0)
            {
                Moveforward();
            }
            else if (Input.GetAxis("Vertical") < 0)
            {
                MoveBack();
            }
            if (Input.GetAxis("fly") > 0)
            {
                MoveUp();
            }
            else if (Input.GetAxis("fly") < 0)
            {
                MoveDown();
            }
        }
        else if (this.typeMove == 3)
        {
            if (Input.GetAxis("Horizontal") > 0)
            {
                Moveleft();
            }
            else if (Input.GetAxis("Horizontal") < 0)
            {
                MoveRight();
            }
            if (Input.GetAxis("Vertical") > 0)
            {
                MoveBack();
            }
            else if (Input.GetAxis("Vertical") < 0)
            {
                MoveUp();
            }
        }
       
        
    }
   */

    public void Jump()
    {


        if (jumps > 0 && temperatureWater <= 99)
        {
            rigidbody.AddForce(new Vector3(0, jumpForce * jumpSpeed,0), ForceMode.Impulse);
            grounded = false;
            jumps = jumps - 1;
        }
        if (jumps == 0)
        {
            return;
        }

    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            jumps = 2;
            grounded = true;
        }
    }
   
}

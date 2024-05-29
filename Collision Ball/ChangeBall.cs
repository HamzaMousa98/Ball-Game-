using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ChangeBall : MonoBehaviour
{
    private GlassBall BallGlass;
    private GameObject Liquid;
    private GameObject Solid;
    private GameObject Gas;
    private GameObject SmakBall;
    private GameObject SmakBallLiquid;
    public ChangeBall(GlassBall BallGlass, GameObject Liquid, GameObject Solid, GameObject Gas, GameObject SmakBall , GameObject smakBallLiquid)
    {
        this.Liquid = Liquid;
        this.Solid = Solid;
        this.Gas = Gas;
        this.SmakBall = SmakBall;
        SmakBallLiquid = smakBallLiquid;
        this.BallGlass = BallGlass;


    }
    public void ChangeBallMaterial(float NewTemperature)
    {
        GameObject.Find("GlassBall").GetComponent<GlassBall>().temperatureWater_ = NewTemperature;
        if (NewTemperature < -5)
        {
            // Game Over
        }
        else if (NewTemperature >= -5 && NewTemperature <= 0)
        {
            Solid.SetActive(true);
            Liquid.SetActive(false);
            Gas.SetActive(false);
            SmakBall.SetActive(false);
            SmakBallLiquid.SetActive(true);
            Solid.GetComponent<Renderer>().material = Resources.Load("BallLiquidMatrial/IceBall 1", typeof(Material)) as Material;
            Solid.GetComponent<Renderer>().material.SetFloat("_fill", this.BallGlass.SizeWater_);
            GameObject.Find("GlassBall").GetComponent<Rigidbody>().useGravity = true;
            BallGlass.jumpForce_ = 3f;
            BallGlass.jumpSpeed_ = 1;

        }
        else if (NewTemperature > 0 && NewTemperature <= 5)
        {
            Solid.GetComponent<Renderer>().material = Resources.Load("BallLiquidMatrial/Water5", typeof(Material)) as Material;
            Solid.GetComponent<Renderer>().material.SetFloat("_fill", this.BallGlass.SizeWater_);
            Solid.SetActive(true);
            Liquid.SetActive(false);
            Gas.SetActive(false);
            SmakBall.SetActive(false);
            SmakBallLiquid.SetActive(true);
            GameObject.Find("GlassBall").GetComponent<Rigidbody>().useGravity = true;
            BallGlass.jumpForce_ = 2.8f;
            Solid.GetComponent<Waterinteraction>().WobbleSpeed = 0.2f;
            BallGlass.jumpSpeed_ = 1;


        }
        else if (NewTemperature > 5 && NewTemperature <= 10)
        {
            Solid.GetComponent<Renderer>().material = Resources.Load("BallLiquidMatrial/Water10", typeof(Material)) as Material; ;
            Solid.SetActive(true);
            Solid.GetComponent<Renderer>().material.SetFloat("_fill", this.BallGlass.SizeWater_);

            Liquid.SetActive(false);
            Gas.SetActive(false);
            SmakBallLiquid.SetActive(true);
            GameObject.Find("GlassBall").GetComponent<Rigidbody>().useGravity = true;
            SmakBall.SetActive(false);
            Solid.GetComponent<Waterinteraction>().WobbleSpeed = 0.4f;
            BallGlass.jumpForce_ = 2.6f;
            BallGlass.jumpSpeed_ = 1;
        }
        else if (NewTemperature > 10 && NewTemperature <= 15)
        {
            Solid.GetComponent<Renderer>().material = Resources.Load("BallLiquidMatrial/Water15", typeof(Material)) as Material;
            Solid.GetComponent<Renderer>().material.SetFloat("_fill", this.BallGlass.SizeWater_);
            Solid.SetActive(true);
            Liquid.SetActive(false);
            Gas.SetActive(false);
            SmakBallLiquid.SetActive(true);
            GameObject.Find("GlassBall").GetComponent<Rigidbody>().useGravity = true;
            Solid.GetComponent<Waterinteraction>().WobbleSpeed = 0.6f;
            SmakBall.SetActive(false);
            BallGlass.jumpForce_ = 2.5f;
            BallGlass.jumpSpeed_ = 1;

        }
        else if (NewTemperature > 15 && NewTemperature <= 20)
        {
           

            SmakBall.SetActive(false);
            Solid.SetActive(true);
            Liquid.SetActive(false);
            Gas.SetActive(false);
            SmakBallLiquid.SetActive(true);
            Solid.GetComponent<Renderer>().material = Resources.Load("BallLiquidMatrial/Water20", typeof(Material)) as Material;
            Solid.GetComponent<Renderer>().material.SetFloat("_fill", this.BallGlass.SizeWater_);
            GameObject.Find("GlassBall").GetComponent<Rigidbody>().useGravity = true;
            Solid.GetComponent<Waterinteraction>().WobbleSpeed = 0.8f;
            BallGlass.jumpForce_ = 2.4f;
            BallGlass.jumpSpeed_ = 1;
        }
        
        if (NewTemperature <= 99 && NewTemperature > 20)
        {
                  Liquid.SetActive(true);
                  Solid.SetActive(false);
                  Gas.SetActive(false);
                  SmakBallLiquid.SetActive(false);
                  GameObject.Find("GlassBall").GetComponent<Rigidbody>().useGravity = true;
                  Liquid.GetComponent<Renderer>().material.SetFloat("_fill", this.BallGlass.SizeWater_);
                  BallGlass.jumpForce_ = 2.2f;
                  BallGlass.jumpSpeed_ = 1;
                  SmakBall.SetActive(false);

        }
        if (NewTemperature >= 100 && NewTemperature <= 120)
        {
            SmakBall.SetActive(true);
            Gas.SetActive(true);
            Liquid.SetActive(false);
            Solid.SetActive(false);
            SmakBallLiquid.SetActive(false);
            GameObject.Find("GlassBall").GetComponent<Rigidbody>().useGravity = true;
        }
        if(NewTemperature > 120)
        {
            // Game Over
        }
    }
}

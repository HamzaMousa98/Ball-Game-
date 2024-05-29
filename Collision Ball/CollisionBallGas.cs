using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CollisionBallGas : CollisionBall
{
    public GameObject smokeBall;
    public GameObject smokeBallLiquid;
    private bool OnColisionSmoke;
    public SavePoint savePoint;

    //_____________________________________________________________________
    private void Start()
    {
        //GlassBall_ = GameObject.Find("GlassBall").GetComponent<GlassBall>();
        this.GlassBall_ = GameObject.Find("GlassBall").GetComponent<GlassBall>();
        Water_ = GameObject.Find("Gas");
        changeBall_ = new ChangeBall(this.GlassBall_,liquid, Solid, Gas, smokeBall, smokeBallLiquid);
        OnColisionSmoke = false;

    }
    private void Update()
    {
        if (!OnColisionSmoke)
        {
            GlassBall_.SizeWater_ = GlassBall_.SizeWater_ - 0.0001f;
        }

        GetComponent<Renderer>().material.SetFloat("_fill", this.GlassBall_.SizeWater_);
    }
    //_____________________________________________________________________
    public void OnTriggerEnter(Collider other)
    {


        if (other.gameObject.tag.Equals("End"))
        {
            savePoint = GlassBall_.savePoint_;
            savePoint.LoadSavePoint();
            changeBall_.ChangeBallMaterial(GlassBall_.temperatureWater_);
            GlassBall_.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
            GlassBall_.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.None;
            GlassBall_.maxHealth_--;
        }

        //------------------------------------------------------
        if (other.gameObject.tag.Equals("ToSolid"))
        {
            changeBall_.ChangeBallMaterial(0);


        }
        if (other.gameObject.tag.Equals("ToLiquid"))
        {
            changeBall_.ChangeBallMaterial(50);


        }
        else if (other.gameObject.tag.Equals("ToSmoke"))
        {
            changeBall_.ChangeBallMaterial(100);
        }
        //------------------------------------------------------

        if (other.gameObject.tag.Equals("Smoke"))
        {

            Rigidbody rigidbody = GameObject.Find("GlassBall").GetComponent<Rigidbody>();
            rigidbody.useGravity = false;
            if (GameObject.Find("GlassBall").GetComponent<GlassBall>().SizeWaterL_ != 0)
                GameObject.Find("GlassBall").GetComponent<GlassBall>().rigidbody_.mass = (GameObject.Find("GlassBall").GetComponent<GlassBall>().SizeWaterL_ / 80) + 0.6f;
            GameObject.Find("GlassBall").GetComponent<GlassBall>().typeMove_ = 2;

           
            
        }

        //_____________________________________________________________________
        //-------------------game
        if (other.gameObject.name.Equals("Game1"))
        {
            other.gameObject.AddComponent<Rigidbody>();

        }
        else if (other.gameObject.name.Equals("Game2"))
        {
            GameObject.Find("Game1").AddComponent<Rigidbody>();
        }
        else if (other.gameObject.name.Equals("Game3"))
        {
            GameObject.Find("Game4").AddComponent<Rigidbody>();
        }
        else if (other.gameObject.name.Equals("Game4"))
        {
            other.gameObject.AddComponent<Rigidbody>();
        }
        else if (other.gameObject.name.Equals("Game5"))
        {
            GameObject.Find("Game6").AddComponent<Rigidbody>();

        }
        else if (other.gameObject.name.Equals("Game6"))
        {
            other.gameObject.AddComponent<Rigidbody>();

        }

        //-------------------
        if (other.gameObject.tag.Equals("GameMove"))
        {
            GameObject.Find("Game1").AddComponent<Rigidbody>();
            GameObject.Find("Game4").AddComponent<Rigidbody>();
            GameObject.Find("Game6").AddComponent<Rigidbody>();
        }
        //-------------------

        //-------------------
        //---------Save Point---------------
        if (other.gameObject.tag.Equals("SavePoint"))
        {
            savePoint = other.gameObject.GetComponent<SavePoint>();
            GlassBall_.savePoint_ = savePoint;
            changeBall_.ChangeBallMaterial(GlassBall_.temperatureWater_);
            other.gameObject.GetComponent<MeshRenderer>().enabled = false;
            other.gameObject.GetComponent<CapsuleCollider>().enabled = false;

        }
        //----------------------------------
    }
    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag.Equals("Water"))
        {


            float x, z;
            x = other.gameObject.transform.localScale.x;
            z = other.gameObject.transform.localScale.z;


            if (x <= 0 || z <= 0)
                Destroy(other.gameObject);
            else
            {
                other.gameObject.transform.localScale = new Vector3(x - 0.005f, 0.01f, z - 0.005f);
                this.GlassBall_.temperatureWater_ = this.GlassBall_.temperatureWater_ - 0.02f;
                changeBall_.ChangeBallMaterial(GlassBall_.temperatureWater_);
                this.GlassBall_.SizeWater_ = this.GlassBall_.SizeWater_ + 0.0002f;
            }
        }
        if (other.gameObject.tag.Equals("Smoke"))
        {

            GlassBall_.SizeWater_ = GlassBall_.SizeWater_ + 0.0001f;
            GetComponent<Renderer>().material.SetFloat("_fill", GlassBall_.SizeWater_);
            if (GameObject.Find("GlassBall").GetComponent<GlassBall>().SizeWaterL_ != 0)
            GameObject.Find("GlassBall").GetComponent<Rigidbody>().mass = (GameObject.Find("GlassBall").GetComponent<GlassBall>().SizeWaterL_ / 100) + 0.6f;
            OnColisionSmoke = true;
        }
        if (other.gameObject.tag.Equals("Fair"))
        {
            this.GlassBall_.temperatureWater_ = this.GlassBall_.temperatureWater_ + 0.05f;
            changeBall_.ChangeBallMaterial(this.GlassBall_.temperatureWater_);
        }
        if (other.gameObject.tag.Equals("ice"))
        {
            this.GlassBall_.temperatureWater_ = this.GlassBall_.temperatureWater_ - 0.02f;
            changeBall_.ChangeBallMaterial(this.GlassBall_.temperatureWater_);
        }

        if (other.gameObject.tag.Equals("Reverse"))
        {
            this.GlassBall_.typeMove_ = 4;
            this.GlassBall_.jumps_ = 0;
        }
        //game-----------------
        if (other.gameObject.name.Equals("Button"))
        {
            if (GlassBall_.SizeWaterL_ >= 140)
            {
                GameObject MoveGround = GameObject.Find("MoveGround");
                MoveGround.transform.position = new Vector3(MoveGround.transform.position.x, MoveGround.transform.position.y, MoveGround.transform.position.z + 0.01f);
            }
        }
        //------------------------
    }
    //_____________________________________________________________________
    private void OnTriggerExit(Collider other)
    {
      if (other.gameObject.tag.Equals("Smoke"))
        {

            Rigidbody rigidbody = GameObject.Find("GlassBall").GetComponent<Rigidbody>();
            rigidbody.useGravity = true;
            GameObject.Find("GlassBall").GetComponent<GlassBall>().typeMove_ = 1;
            OnColisionSmoke = false;
        }
        if (other.gameObject.tag.Equals("Reverse"))
        {
            this.GlassBall_.typeMove_ = 2;
            this.GlassBall_.jumps_ = 2;
        }
    }
    //_____________________________________________________________________

}

using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CollisionBallSolid : CollisionBall
{
    public GameObject smokeBall;
    public GameObject smokeBallLiquid;
    public SavePoint savePoint;

    //_____________________________________________________________________
    private void Start()
    {
        this.GlassBall_ = GameObject.Find("GlassBall").GetComponent<GlassBall>();
        Water_ = GameObject.Find("Solid");
        changeBall_ = new ChangeBall(this.GlassBall_,liquid, Solid, Gas, smokeBall, smokeBallLiquid);
        savePoint = liquid.GetComponent<CollisionBallLiquid>().savePoint;

    }
    //_____________________________________________________________________
    private void Update()
    {
        GetComponent<Renderer>().material.SetFloat("_fill", this.GlassBall_.SizeWater_);
      
        // this.GetComponent<WaterSolid>().glassBall_.temperatureWater_ = this.GetComponent<WaterSolid>().glassBall_.temperatureWater_ - 0.01f;
       //  changeBall_.ChangeBallMaterial(this.GetComponent<WaterSolid>().glassBall_.temperatureWater_);
    }
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

        //_____________________________________________________________________
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
        if (other.gameObject.tag.Equals("Fair"))
        {
            this.GlassBall_.temperatureWater_ = this.GlassBall_.temperatureWater_ + 0.02f;
            changeBall_.ChangeBallMaterial(this.GlassBall_.temperatureWater_);
        }
        if (other.gameObject.tag.Equals("ice"))
        {
            this.GlassBall_.temperatureWater_ = this.GlassBall_.temperatureWater_ - 0.02f;
            changeBall_.ChangeBallMaterial(this.GlassBall_.temperatureWater_);
        }

        if (other.gameObject.tag.Equals("Reverse"))
        {
            this.GlassBall_.typeMove_ = 3;
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
    private void OnTriggerExit(Collider other)
    {

        if (other.gameObject.tag.Equals("Reverse"))
        {
            this.GlassBall_.typeMove_ = 1;
            this.GlassBall_.jumps_ = 2;
        }
    }
}

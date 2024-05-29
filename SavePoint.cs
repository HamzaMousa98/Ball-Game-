using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SavePoint : MonoBehaviour
{
    private float size , tem ;
    private GlassBall glassBall;

    private void Start()
    {
      //  glassBallNew = new GlassBall();
        glassBall = GameObject.Find("GlassBall").GetComponent<GlassBall>();
        tem = 30;
        size = -0.15f;
    }

    public SavePoint()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag.Equals("Ball")) {
            tem = glassBall.temperatureWater_;
            size = glassBall.SizeWater_;
            
        }
        
    }

    public void LoadSavePoint()
    {
        glassBall.temperatureWater_ = tem;
        glassBall.SizeWater_ = size;
        glassBall.transform.position = this.transform.position;

        if(this.name.Equals("SavePoint1"))
            GameObject.Find("Wall1").GetComponent<BoxCollider>().enabled = true;
        else if (this.name.Equals("SavePoint2"))
            GameObject.Find("Wall2").GetComponent<BoxCollider>().enabled = true;
        else if (this.name.Equals("SavePoint3"))
            GameObject.Find("Wall3").GetComponent<BoxCollider>().enabled = true;
        else if (this.name.Equals("SavePoint4"))
            GameObject.Find("Wall4").GetComponent<BoxCollider>().enabled = true;

    }
}

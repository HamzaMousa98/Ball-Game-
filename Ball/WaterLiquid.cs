using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using Unity.VisualScripting;
using UnityEngine;

public class WaterLiquid : Water
{

   // تعريف المتغيرات
    void Start()
    {
        glassBall_ = GameObject.Find("GlassBall").GetComponent<GlassBall>();
        /*glassBall_.temperatureWater_ = 25;
        glassBall_.SizeWater_ = -0.15f;
        glassBall_.weight_ = 0.6f;*/

    }
    //_____________________________________________________________________

    void Update()
    {
        temperature_ = glassBall_.temperatureWater_;
        Size_ = glassBall_.SizeWater_;
        weight_ = glassBall_.weight_;
        this.GetComponent<Renderer>().material.SetFloat("_fill", Size_);
    }
    //_____________________________________________________________________

}

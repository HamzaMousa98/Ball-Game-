using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class WaterSolid : Water
{
    // تعريف المتغيرات
    void Start()
    {
        glassBall_ = GameObject.Find("GlassBall").GetComponent<GlassBall>();
        temperature_ = glassBall_.temperatureWater_;
        Size_ = glassBall_.SizeWater_;
        weight_ = glassBall_.weight_;

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

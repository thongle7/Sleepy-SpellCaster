﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[Serializable]
public class Stat
{
    [SerializeField]
    private BarScript bar;

    [SerializeField]
    private float maxVal;

    [SerializeField]
    private float curVal;

    public float CurVal
    {
        get
        {
            return curVal;
        }

        set
        {
            //set current value before updating bar
            this.curVal = Mathf.Clamp(value, 0, MaxVal);
            bar.Value = curVal;
        }
    }

    public float MaxVal
    {
        get
        {
            return maxVal;
        }

        set
        {
            this.maxVal = value;
            bar.MaxValue = maxVal;
        }

    }

    public void Initialize()
    {
        this.MaxVal = maxVal;
        this.CurVal = curVal;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public abstract class OptionText 
{
    protected int value;
    protected int lifeReduce;
    protected string text;
    protected Action SuccessCallback;
    protected Action FailureCallback;

    public string Text => text;
    public OptionText(int value, int lifereduce, string text)
    {
        this.value = value;
        lifeReduce = lifereduce;
        this.text = text;
    }

    public void SetCallback(Action SuccessCallback, Action FailureCallback)
    {
        this.SuccessCallback = SuccessCallback;
        this.FailureCallback = FailureCallback;
    }

    public abstract void Decide();
}

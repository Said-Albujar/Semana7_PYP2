using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Strength : OptionText
{
    public Strength(int value, int lifeReduce, string text) : base(value, lifeReduce, text)
    {
    }

    public override void Decide()
    {
        if (value > Player.PlayerS.Fuerza)
        {
            Player.PlayerS.ChangeLife(-lifeReduce);
            FailureCallback?.Invoke();
        }
        else
        {
            SuccessCallback?.Invoke();
        }
    }
}

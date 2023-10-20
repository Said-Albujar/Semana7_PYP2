using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dextery : OptionText
{
    public Dextery(int value, int lifeReduce, string text) : base(value, lifeReduce, text)
    {
    }

    public override void Decide()
    {
        if (value > Player.PlayerS.Destreza)
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

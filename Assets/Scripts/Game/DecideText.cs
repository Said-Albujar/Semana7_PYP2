using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DecideText : GameText
{
    private List<OptionText> decideList;

    public List<OptionText> OptionList => decideList;

    public DecideText(string text) : base(text)
    {
        decideList = new List<OptionText>();
    }

    public void AddOption(OptionText option)
    {
        decideList.Add(option);
    }
}

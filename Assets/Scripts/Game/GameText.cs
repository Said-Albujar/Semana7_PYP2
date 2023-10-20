using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameText
{
    protected string lore;

    protected GameText nextDialogue;

    public string Text => lore;
    public GameText NextDialogue => nextDialogue;

    public GameText(string text)
    {
        lore = text;
    }

    public void NextText(GameText nexttext)
    {
        nextDialogue = nexttext;
    }
}

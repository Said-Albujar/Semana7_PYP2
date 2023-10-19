using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerUI : MonoBehaviour
{
    public TextMeshProUGUI nameText;
    public TextMeshProUGUI lifeText;
    public TextMeshProUGUI strengthText;
    public TextMeshProUGUI dexteryText;

    void Start()
    {
        nameText.text = $"Nombre: {Player.PlayerS.Nombre}";
        lifeText.text = $"Vida: {Player.PlayerS.Vida}";
        strengthText.text = $"Fuerza: {Player.PlayerS.Fuerza}";
        dexteryText.text = $"Destreza: {Player.PlayerS.Destreza}";

        Player.PlayerS.LifeChange += LifeChange;
    }

    void LifeChange(int value)
    {
        lifeText.text = $"Life: {value}";
    }

    private void OnDestroy()
    {
        Player.PlayerS.LifeChange -= LifeChange;
    }
}

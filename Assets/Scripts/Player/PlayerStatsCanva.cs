using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using System;

public class PlayerStatsCanva : MonoBehaviour
{
    public TextMeshProUGUI PuntosTexto;
    public TMP_InputField NombreTexto;
    public TMP_InputField VidaTexto;
    public TMP_InputField FuerzaTexto;
    public TMP_InputField DestrezaTexto;
    public Button Comenzar;

    private Action OnCallback;
    private void Awake()
    {
        VidaTexto.onValueChanged.AddListener(Stats);
        FuerzaTexto.onValueChanged.AddListener(Stats);
        DestrezaTexto.onValueChanged.AddListener(Stats);
        Comenzar.onClick.AddListener(ButtonClicked);
    }

    public void SetCallback(Action OnCallback)
    {
        this.OnCallback = OnCallback;

    }

    void Stats(string value)
    {
        int points = 100;

        if (VidaTexto.text.Length > 0)
        {
            points -= int.Parse(VidaTexto.text);
        }
        if (FuerzaTexto.text.Length > 0)
        {
            points -= int.Parse(FuerzaTexto.text);
        }
        if (DestrezaTexto.text.Length > 0)
        {
            points -= int.Parse(DestrezaTexto.text);
        }

        PuntosTexto.text = $"Puntos: {points}";
    }

    private void ButtonClicked()
    {
        if (Player.PlayerS.StatsVerificate(NombreTexto.text, int.Parse(VidaTexto.text), int.Parse(FuerzaTexto.text), int.Parse(DestrezaTexto.text)))
        {
            Player.PlayerS.PlayerStats(NombreTexto.text, int.Parse(VidaTexto.text), int.Parse(FuerzaTexto.text), int.Parse(DestrezaTexto.text));
            OnCallback?.Invoke();
        }
    }
}

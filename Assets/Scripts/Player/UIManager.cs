using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public GameObject PlayerCanva;
    public GameObject GameCanva;

    private void Awake()
    {
        PlayerCanva.GetComponent<PlayerStatsCanva>().SetCallback(GameCanvas);
        GameCanva.SetActive(false);
    }

    void GameCanvas()
    {
        PlayerCanva.SetActive(false);
        GameCanva.SetActive(true);
    }
}

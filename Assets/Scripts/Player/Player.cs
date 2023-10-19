using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public string Name;
    public int Life;
    public int Strength;
    public int Dextery;

    public string Nombre => Name;
    public int Vida => Life;
    public int Fuerza => Strength;
    public int Destreza => Dextery;

    private static Player player;
    public static Player PlayerS => player;
    public event Action<int> LifeChange = (value) => { };

    private void Awake()
    {
        player = this;
    }

    public bool StatsVerificate(string name, int life, int strength, int dextery)
    {
        if (name.Length == 0)
        {
            return false;
        }

        if (life <= 0 || strength <= 0 || dextery <= 0)
        {
            return false;
        }

        if (life + strength + dextery> 100)
        {
            return false;
        }

        return true;

    }

    public void PlayerStats(string name, int life, int strength, int dextery)
    {
        this.Name = name;
        this.Life = life;
        this.Strength = strength;
        this.Dextery = dextery;
    }

    public void ChangeLife(int value)
    {
        Life += value;
        LifeChange?.Invoke(Life);
    }
}

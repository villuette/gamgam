using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface Stats
{
    public int GG_Experience { get => GG_Experience; set => GG_Experience = value; };
    public int GG_Gold;
    public int GG_Health;
    public int GG_Mana = 0;
    public int GG_Damage = 6;
    public float GG_Armor = 0.0f;
    public float GG_CRT_CHN = 0.1f;
    public float GG_CRT_DMG = 1.0f;
    public float GG_SUP = 0.0f;
    public int GG_SUP_Manacost = 1;
}
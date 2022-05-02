using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MusicalRunes;

[CreateAssetMenu(fileName = "new PowerUp Config", menuName = "Configs/Power Up")]
public class PowerUpConfig: ScriptableObject
{
    public PowerUpType powerUpType;
    public string m_powerUpNames;
    [TextArea] public string m_description;
}


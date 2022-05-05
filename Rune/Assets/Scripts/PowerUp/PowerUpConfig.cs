using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MusicalRunes;
[System.Serializable]
[CreateAssetMenu(fileName = "new PowerUp Config", menuName = "Configs/Power Up")]

public class PowerUpConfig: ScriptableObject
{
    public PowerUpType powerUpType;
    public string m_powerUpNames;
    [TextArea] public string m_description;

    public bool m_Upgradeable;

    //public string m_powerUpNameID;
    //public string m_descriptionID;
    //public string m_powerUpNames => Localization.s_currenLocalizationTable[m_powerUpNameID];
    //public string m_description => Localization.s_currenLocalizationTable[m_descriptionID];
}


using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MusicalRunes;

[System.Serializable]
[CreateAssetMenu(fileName = "new PowerUp Config", menuName = "Configs/Power Up")]

public class PowerupUpgradePopup : MonoBehaviour
{
    public PowerUpType powerUpType;
    public string m_powerUpNames;
    [TextArea] public string m_description;
    public PowerUpConfig m_powerUp;
    public bool m_Upgradeable;
    private void Start()
    {
        Setup(m_powerUp);
    }
    public void Setup(PowerUpConfig powerupConfig)
    {
        powerUpType = powerupConfig.powerUpType;
        m_powerUpNames = powerupConfig.m_powerUpNames;
        m_description = powerupConfig.m_description;
        m_Upgradeable = powerupConfig.m_Upgradeable;
    }
}

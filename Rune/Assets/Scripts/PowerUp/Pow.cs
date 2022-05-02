using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MusicalRunes;
public class Pow : MonoBehaviour
{
    public PowerUpConfig m_powerUp;

    private void Start()
    {
        Debug.Log(m_powerUp.m_powerUpNames);
        Debug.Log(m_powerUp.m_description);
        if(m_powerUp.powerUpType == PowerUpType.hint)
        {
            Debug.Log("true");
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MusicalRunes
{   
    
    public enum PowerUpType
    {
        hint, replay
    }

    public class PowerUpManager : MonoBehaviour
    {
        [SerializeField] PowerUpType pType;

        private void Start()
        {
            if(pType == PowerUpType.hint)
            {

            }
            else if (pType == PowerUpType.replay)
            {

            }
        }
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinLightManager : MonoBehaviour
{
    [SerializeField] private GameObject[] m_spineLight;

    private void Start()
    {
        StartCoroutine(FlashLights());
    }
    IEnumerator FlashLights()
    {   
        while (true)
        {
            yield return new WaitForSeconds(0.5f);

            foreach(GameObject go in m_spineLight)
            {/*
                if (!go.activeSelf)
                {
                    go.SetActive(true);
                }
                else
                {
                    go.SetActive(false);
                }
                */
                //go.SetActive(go.activeSelf?false:true);
                go.SetActive(!go.activeSelf);

                //go.activeSelf? go.SetActive(true) : go.SetActive(false);

            }
        }
    }
}

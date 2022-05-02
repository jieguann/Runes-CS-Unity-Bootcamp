using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spinlight : MonoBehaviour
{
    [SerializeField] [Range(-90f, 90f)] private float m_speed = 5f;
    [SerializeField] private float move = 0.01f;
    
    void Update()
    {
        //move += m_speed * Time.deltaTime;
        //transform.eulerAngles = new Vector3(0,0,move);
        transform.Rotate(0, 0, m_speed * Time.deltaTime);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestBehaviour : MonoBehaviour
{
    [SerializeField] List<Vector3> points;
    [SerializeField] List<float> speed;
    [SerializeField] int startPoint = 0;
    [SerializeField] int pointsIndex;
    [SerializeField] int speedsIndex =0;
    
    // Start is called before the first frame update
    void Start()
    {
        transform.position = points[startPoint];
        pointsIndex = startPoint + 1;
    }

    // Update is called once per frame
    void Update()
    {
        if(points.Count > 0)
        {
            var step = speed[speedsIndex] * Time.deltaTime;
            transform.position = Vector3.MoveTowards(transform.position, points[pointsIndex], step);
            if (transform.position == points[pointsIndex])
            {
                if (pointsIndex < points.Count-1)
                {
                    pointsIndex = pointsIndex + 1;
                    speedsIndex = speedsIndex + 1;
                }
                else
                {
                    pointsIndex = 0;
                    speedsIndex = 0;
                }
            }
            
        }
    }
        
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeemTop : MonoBehaviour
{
    bool _isFirst;

    void Start()
    {
        
    }


    Vector3 CircleHorizon(float radius)
    {
        var angle = Random.Range(0, 360);
        var rad = angle * Mathf.Deg2Rad;
        var px = Mathf.Cos(rad) * radius;
        var py = Mathf.Sin(rad) * radius;
        return new Vector3(px, py, 0);
    }
}

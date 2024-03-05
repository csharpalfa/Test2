using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleComponent : MonoBehaviour
{
    private float startZPosition;
    private void Start()
    {
        startZPosition = transform.position.z;
    }
}
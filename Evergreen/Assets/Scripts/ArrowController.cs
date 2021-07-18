using System.Transactions;
using System.Runtime.InteropServices;
using System;
//using System.Numerics;
//using System.Threading.Tasks.Dataflow;
using System.Runtime.CompilerServices;
//using System.ComponentModel.DataAnnotations.Schema;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowController : MonoBehaviour
{
    Vector3 mousePos;
    Vector3 screenPoint;
    Vector3 offset;
    float angle;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        mousePos = Input.mousePosition;
        screenPoint = Camera.main.WorldToScreenPoint(transform.position);
        offset = new Vector2(mousePos.x - screenPoint.x, mousePos.y - screenPoint.y);

        angle = Mathf.Atan2(offset.y, offset.x) * Mathf.Rad2Deg;

        transform.rotation = Quaternion.Euler(0,0,angle);
    }
}

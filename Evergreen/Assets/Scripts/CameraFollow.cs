//using System.Threading.Tasks.Dataflow;
//using System.Numerics;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform player;
    public float velocidade;

    void FixedUpdate()
    {
        transform.position = Vector2.Lerp(transform.position, player.position, velocidade);
    }
}

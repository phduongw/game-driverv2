using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Colision : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Colision");
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("What was that!???");
    }
}

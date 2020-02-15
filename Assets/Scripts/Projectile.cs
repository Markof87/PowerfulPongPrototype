﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Paddle")
            other.gameObject.GetComponent<Paddle>().HurtByIceProjectile();

        Destroy(gameObject);
    }
}
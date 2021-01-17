﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CauldronScript : MonoBehaviour
{


    private void OnTriggerStay(Collider other)
    {
        Debug.Log("Entered Cauldron");
        other.GetComponent<Rigidbody>().AddForce(new Vector3(Random.Range(-100f, 100f), 200, Random.Range(-100f, 100f)));
    }
}
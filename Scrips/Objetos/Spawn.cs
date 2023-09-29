using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
public GameObject enemigo;

public GameObject spawn;

public void OnTriggerEnter(Collider other)
{
    if(other.tag=="Player") {
    Instantiate(enemigo,spawn.transform.position,transform.rotation);
   
    }
}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinsCollide : MonoBehaviour
{
    void OnTriggerEnter(Collider other){
        Destroy(gameObject);
    }
}

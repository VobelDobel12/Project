using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HaystackCollide : MonoBehaviour
{
    public int jump = 3;
    void OnTriggerEnter(Collider other)
    {
        //Увеличение скорости бега игрока
        Jump player = other.GetComponent<Jump>();
        if (player){
            player.jumpStrength *= jump;
        }
    }
    void OnTriggerExit(Collider other){
        Jump player = other.GetComponent<Jump>();
        if (player){
            player.jumpStrength /= jump;
        }
    }
}

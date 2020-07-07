using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour{
    public Transform bulbPoint;
    public GameObject bulbPrefab;

    //public PlayerStats playerStats;

    void Update(){
        if(Input.GetButtonDown("Fire1")){
            Shoot();
        }
    }
    void Shoot(){
        Instantiate(bulbPrefab, bulbPoint.position, bulbPoint.rotation);
    }
}

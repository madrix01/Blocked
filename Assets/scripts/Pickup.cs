using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup : MonoBehaviour
{
    public PlayerStats playerStats;
    public Transform pickupPoint;
    public GameObject weaponPrefab;
    public GameObject parent;
    private GameObject s1;

    void OnTriggerEnter2D(Collider2D hitinfo){
        if(hitinfo.tag == "Player" && playerStats.isEquippedWeapon == false){
            s1 = Instantiate(weaponPrefab, pickupPoint.position, pickupPoint.rotation);
            s1.transform.SetParent(parent.transform);
            Destroy(gameObject);
            playerStats.isEquippedWeapon = true;
        }
    }
}

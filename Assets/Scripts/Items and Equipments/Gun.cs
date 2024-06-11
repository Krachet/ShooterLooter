using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    public ScriptableGunTypes gunType;

    //Gun Stats
    public int ammo;
    public int maxAmmo;
    public float fireRate;
    public float reloadTime;
    public int burstAmount;
    public float damage;
    // Start is called before the first frame update
    void Start()
    {
        ammo = gunType.ammo;
        maxAmmo = gunType.maxAmmo;
        fireRate = gunType.fireRate;
        reloadTime = gunType.reloadTime;
        burstAmount = gunType.burstAmount;
        damage = gunType.damage;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

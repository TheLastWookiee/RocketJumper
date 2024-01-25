using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RPGScript : MonoBehaviour
{   [Header("Refrences")]
    [SerializeField] GunData gunData;
    // Start is called before the first frame update
    
    private void Start()
    {
        PlayerShoot.shootInput += Shoot;
    }
    private bool CanShoot() => !gunData.reloading && timeSinceLastShot > 1f / (gunData.fireRate / 60f);
    private void Shoot()
    {//make sure we have ammo
        if (gunData.currentAmmo > 0) { if(CanShoot()){
            if(Physics.Raycast(transform.position, transform.forward, out RaycastHit hitInfo, gunData.maxDistance))
                {
                    Debug.Log(hitInfo.transform.name); 
                }
                    }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}

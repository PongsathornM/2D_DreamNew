using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Weapon : MonoBehaviour
{
    public GameObject bulletPrefab;
    public Transform LaunchOffset;
    public float fireForce = 20f;
    public int currentClip, maxClip = 7, currentAmmo, maxAmmo = 20;
    // Shoot

    public void Fire()
    {
        
        if (Input.GetButtonDown("Fire1"))
        {
            if (currentClip > 0)
            {
                GameObject bullet = Instantiate(bulletPrefab, LaunchOffset.position, LaunchOffset.transform.rotation);
                // 2 bullet.GetComponent<Rigidbody2D>().AddForce(Vector2.right * fireForce);
                /*if (Position.)
                {
                    
                }*/
                bullet.GetComponent<Rigidbody2D>().AddForce(LaunchOffset.right * fireForce, ForceMode2D.Impulse);
                
                //bullet.transform.localScale = new Vector2(bullet.transform.localScale.x , bullet.transform.localScale.y);


                currentClip--;
            }
        }
        
        if (Input.GetKeyDown(KeyCode.R))
        {
            Reload();
        }
    }
    public void Reload()
    {
        int reloadAmount = maxClip - currentClip; //how many bullets to refill
        reloadAmount = (currentAmmo - reloadAmount) >= 0 ? reloadAmount : currentAmmo;
        currentClip += reloadAmount;
        currentAmmo -= reloadAmount;
    }

    public void AddAmmo(int ammoAmount)
    {
        currentAmmo += ammoAmount;
        if (currentAmmo > maxAmmo)
        {
            currentAmmo = maxAmmo;
        }
    }
}
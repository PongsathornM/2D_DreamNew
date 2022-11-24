using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public Weapon weapon;
    public Text text;
    private void Start()
    {
        UpdateAmmoText();
    }

    private void Update()
    {
        UpdateAmmoText();
    }

    public void UpdateAmmoText()
    {
        text.text = $"Ammo : {weapon.currentClip} / {weapon.maxClip} | Total Ammo : {weapon.currentAmmo} / {weapon.maxAmmo}";
    }
}

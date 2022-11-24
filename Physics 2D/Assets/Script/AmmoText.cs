using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class AmmoText : MonoBehaviour
{
    public Weapon weapon;
    public TextMeshProUGUI text;
    void Start()
    {
        UpdateAmmoText();
    }

    // Update is called once per frame
    void Update()
    {
        UpdateAmmoText();
    }

    public void UpdateAmmoText()
    {
        text.text = $"{weapon.currentClip} / {weapon.maxClip} | {weapon.currentAmmo} / {weapon.maxAmmo}";
    }
}

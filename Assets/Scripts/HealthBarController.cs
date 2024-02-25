using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Slider = UnityEngine.UI.Slider;

public class HealthBarController : MonoBehaviour
{
    Slider healthBar;

    int currentHealth;
    // Start is called before the first frame update
    void Start()
    {
        healthBar = GetComponent<Slider>();
        healthBar.value = currentHealth = 100;
        Debug.Log(healthBar.value);
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void GetDamage(int dam)
    {
        Debug.Log("ouch2");
        currentHealth -= dam;
        healthBar.value = currentHealth;
        Debug.Log(healthBar.value);
    }
    public void GetHeal(int heal)
    {
        currentHealth += heal;
        healthBar.value = currentHealth;
        Debug.Log(healthBar.value);
    }
}
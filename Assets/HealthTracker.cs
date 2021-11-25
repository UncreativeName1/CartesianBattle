using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthTracker : MonoBehaviour
{
    public Image healthBar;
    public float totalHealth = 100;
    public float currentHealth = 100;
    public float creaseHealth = 5;
    // Start is called before the first frame update
    void Start()
    {
        setHealth(currentHealth);
    }

    void takeDamage(float amount)
    {
        currentHealth -= amount;
        setHealth(currentHealth);
    }
    // Update is called once per frame
    void Update()
    {
        /*if (Input.GetButtonDown("Fire1"))
        {
            currentHealth -= creaseHealth;
            percentHealth = currentHealth / 100;
            setHealth(percentHealth);
        }
        if (Input.GetButtonDown("Fire2"))
        {
            currentHealth += creaseHealth;
            percentHealth = currentHealth / 100;
            setHealth(percentHealth);
        }*/
    }
    
    void setHealth(float health)
    {
        healthBar.fillAmount = currentHealth / totalHealth;
    }

}

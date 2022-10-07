using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerStats : MonoBehaviour
{
    private float maxHP = 100f;
    public float currentHP;
    public float maxStamina = 200f;
    public float currentStamina;
    public Image healthBar;
    public Image staminaBar;

    void Start()
    {
        currentHP = maxHP;
        currentStamina = maxStamina;
        healthBar.fillAmount = 1f;
        staminaBar.fillAmount = 1f;
    }
    
    void Update()
    {
        PlayerDeath();
    }

    public void TakeDamage(float damage)
    {
        currentHP -= damage;
        healthBar.fillAmount = currentHP / maxHP;
    }
    
    public void GetHeal(float heal)
    {
        if (currentHP < maxHP)
        {
            currentHP += heal;
            currentHP = Mathf.Clamp(currentHP, 0f, maxHP);
            healthBar.fillAmount = currentHP / maxHP;
        }
        
    }
    
    void PlayerDeath()
    {
        if (currentHP <= 0 && gameObject.CompareTag("P1"))
        {
            Destroy(gameObject);
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
            SceneManager.LoadScene(2);
        }
        else if (currentHP <= 0 && gameObject.CompareTag("P2"))
        { 
            Destroy(gameObject); 
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
            SceneManager.LoadScene(3);
            
        }
    }
}


using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerStats : MonoBehaviour
{
    private float maxHP = 100f;

    public float currentHP;

    void Start()
    {
        currentHP = maxHP;
    }

    void Update()
    {
        PlayerDeath();
    }

    public void TakeDamage(float damage)
    {
        currentHP -= damage;
    }
    
    public void GetHeal(float heal)
    {
        if (currentHP < maxHP)
        {
            currentHP += heal;
            currentHP = Mathf.Clamp(currentHP, 0f, maxHP);
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


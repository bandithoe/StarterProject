using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    [SerializeField] private float maxHP = 100f;

    public float currentHP;
    
    void Start()
    {
        currentHP = maxHP;
    }

    void Update()
    {
        if (currentHP <= 0)
        {
            Destroy(gameObject);
        }
    }

    public void TakeDamage(float damage)
    {
        currentHP -= damage;
    }
}


using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private int health;
    public event Action<int> OnTakeDamage;
    public event Action OnDied;
    public void TakeDamage(int damage)
    {
        if (health < damage)
        {
            OnDied.Invoke();
            return;
        }
        health -= damage;
        OnTakeDamage?.Invoke(damage);
    }
}

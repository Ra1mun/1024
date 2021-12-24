using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    [SerializeField] private Player _player;

    private void OnEnable()
    {
        _player.OnTakeDamage += UpdatePlayerHealth;
        _player.OnDied += Death;
    }

    private void OnDisable()
    {
        _player.OnTakeDamage -= UpdatePlayerHealth;
        _player.OnDied -= Death;
    }

    private void UpdatePlayerHealth(int value)
    {
        Debug.Log("TakeDamage");
    }

    private void Death()
    {
        Debug.Log("Death");
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroyer : MonoBehaviour
{
    [SerializeField] private Player _player;

    private void Start()
    {
        _player.OnDied += DestroyDeathObject;
    }

    private void DestroyDeathObject()
    {
        Destroy(_player.gameObject);
    }
}

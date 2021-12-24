using System;
using JetBrains.Annotations;
using UnityEngine;
[RequireComponent(typeof(Rigidbody2D))]
public class Cell : MonoBehaviour
{

    [SerializeField] private SwipeInput _swipeInput;

    [SerializeField] private Rigidbody2D _rigidbody;

    private void OnEnable()
    {
        _swipeInput.OnSwipe += TransformMovement;
    }

    private void OnDisable()
    {
        _swipeInput.OnSwipe -= TransformMovement;
    }

    private void TransformMovement(Vector2Int direction)
    {
        _rigidbody.MovePosition(_rigidbody.position + direction);
    }
}

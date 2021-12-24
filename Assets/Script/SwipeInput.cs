using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwipeInput : MonoBehaviour
{
    [SerializeField] private int _swipeRange;
    [SerializeField] private int _transformRange;
    private Vector2 _tapPosition;

    public event Action<Vector2Int> OnSwipe;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
            _tapPosition = Input.mousePosition;
        if(Input.GetMouseButton(0))
            StartCoroutine(Swipe(_tapPosition));
    }

    private IEnumerator Swipe(Vector2 dot)
    {
        var swipeDelta = (Vector2)Input.mousePosition - dot;

        yield return new WaitUntil(() => Input.GetMouseButtonUp(0));

        if (swipeDelta.magnitude < _swipeRange)
            yield break;

        if (Mathf.Abs(swipeDelta.x) > Mathf.Abs(swipeDelta.y))
        {
            OnSwipe?.Invoke(swipeDelta.x > 0 ? Vector2Int.right * _transformRange : Vector2Int.left * _transformRange);
        }
        else
        {
            OnSwipe?.Invoke(swipeDelta.y > 0 ? Vector2Int.up * _transformRange : Vector2Int.down * _transformRange);
        }
    }
}

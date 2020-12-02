using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private GameObject _point1;
    [SerializeField] private GameObject _point2;
    private float _speed = 5f;
    private bool _checkPoint = true;
    private float _count = 0f;

    private void Update()
    {
        TouchScreen();
        MovePlayer();
    }
    private void MovePlayer()
    {
        switch (_checkPoint)
        {
            case true:
                Move(_point1);
                break;
            case false:
                Move(_point2);
                break;
        }

        void Move(GameObject point)
        {
            transform.position = Vector2.MoveTowards(transform.position, point.transform.position, _speed * Time.deltaTime);
            if (transform.position == point.transform.position)
            {
                _checkPoint = !_checkPoint;
            }
        }
    }
    private void ChangeCounter()
    {
        _count++;
    }
    private void TouchScreen()
    {
        if (Input.GetMouseButtonDown(0))
        /* if (Input.touchCount > 0)*/
        {
            _checkPoint = !_checkPoint;
        }
    }
}

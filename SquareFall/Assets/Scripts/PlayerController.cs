using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private GameObject _point1;
    [SerializeField] private GameObject _point2;
    [SerializeField] private Text _textCounter;
    [SerializeField] private Main _main;
    private float _speed = 5f;
    private bool _checkPoint = true;
    private float _count = 0f;

    private void Update()
    {
        TouchScreen();
        MovePlayer();
        _textCounter.text = _count.ToString();
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
        //if (Input.GetMouseButtonDown(0))
        if (Input.touchCount > 0)
        {
            _checkPoint = !_checkPoint;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Enemy")
        {
            gameObject.SetActive(false);
            _main.GetComponent<Main>().LoseScreen();
        }
        if (collision.gameObject.tag == "Friend")
        {
            ChangeCounter();
            collision.gameObject.SetActive(false);
        }
    }
}

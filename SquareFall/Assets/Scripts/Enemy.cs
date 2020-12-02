using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private Rigidbody2D _rigidbody;
    private float _thrust;

    private void Start()
    {
        _rigidbody = GetComponent<Rigidbody2D>();

    }
    private void Update()
    {
        _thrust = Random.Range(-10f, 10f);
        transform.Rotate(new Vector3(0, 0, 90) * Time.deltaTime);
        //print(_thrust);
    }
    private void FixedUpdate()
    {
        _rigidbody.AddForce(transform.right * -_thrust);
    }
}

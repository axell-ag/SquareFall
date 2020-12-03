using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Quad : MonoBehaviour
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
        DestroyQuad();
    }
    private void FixedUpdate()
    {
        _rigidbody.AddForce(transform.right * _thrust);
    }
    private void DestroyQuad()
    {
        if(transform.position.y <= -6)
        {
            Destroy(gameObject);
        }
    }
}

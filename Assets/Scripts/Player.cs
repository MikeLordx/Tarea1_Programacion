using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private Rigidbody _rigidbody = default;
    [SerializeField] private int _playerVelocity = default;

    private void Start()
    {
        _rigidbody = GetComponent<Rigidbody>(); 
    }

    private void FixedUpdate()
    {
        Vector3 _movement = new Vector3(0, 0, Input.GetAxisRaw("Vertical"));
        _rigidbody.MovePosition(transform.position + _movement * Time.deltaTime * _playerVelocity);

    }
}

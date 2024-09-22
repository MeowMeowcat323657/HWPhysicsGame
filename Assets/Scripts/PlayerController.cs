using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private Rigidbody _rigidbody;
    [SerializeField] private float _startSpeed;
    [SerializeField] private float _jumpPower;

    private void Update()
    {
        Vector3 input = new Vector3(Input.GetAxisRaw("Horizontal"), 0, Input.GetAxisRaw("Vertical"));
        _rigidbody.AddForce(input.normalized * _startSpeed, ForceMode.Force);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Jump(_jumpPower);
        }
    }
    private void Jump(float jumpPower)
    {
        _rigidbody.AddForce(Vector3.up * jumpPower, ForceMode.Impulse);
    }


}

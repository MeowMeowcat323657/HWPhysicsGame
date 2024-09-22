using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private Rigidbody _rigidbody;
    [SerializeField] private float _startSpeed;
    [SerializeField] private float _jumpPower;
    [SerializeField] private string _groundTag;
    private bool _canJump = true;


    private void Update()
    {
        Vector3 input = new Vector3(Input.GetAxisRaw("Horizontal"), 0, Input.GetAxisRaw("Vertical"));
        _rigidbody.AddForce(input.normalized * _startSpeed, ForceMode.Force);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Jump(_jumpPower);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == _groundTag)
        {
            _canJump = true;
        }
    }
    private void Jump(float jumpPower)
    {
        if (_canJump)
        {
            _rigidbody.AddForce(Vector3.up * jumpPower, ForceMode.Impulse);
            _canJump = false;
        }
    }


}

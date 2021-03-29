using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JampRex : MonoBehaviour
{
    public float jampForce;
    public float downForce;

    public bool _checkIsGround = false;

    public Rigidbody _rigidbody;
    public Animator _anim;
    void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
        _anim = GetComponent<Animator>();
    }
    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.Space))
        {
            if (_checkIsGround == false)
            {
                _anim.speed = PlayerPrefs.GetFloat("Speed") / 100 * 30;
                _rigidbody.AddForce(transform.up * jampForce);
                _checkIsGround = true;
            }
        }
        if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
        {
            if (_checkIsGround == true)
                _rigidbody.AddForce(transform.up * -downForce);
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.name.IndexOf("tf") > 0)
        {
            _checkIsGround = false;
            _anim.speed = PlayerPrefs.GetFloat("Speed") / 100 * 15;
        }
    }
}

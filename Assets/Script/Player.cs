using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] float _speed = 5f;
    Vector3 _dir = default;
    Rigidbody _rb;
    Animator _ani;
    void Start()
    {
        _rb = GetComponent<Rigidbody>();
        _ani = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxisRaw("Horizontal");
        float v = Input.GetAxisRaw("Vertical");
        _dir = new Vector3(h, 0, v);

        if (_dir != Vector3.zero)
        {
            this.transform.forward = _dir;
        }
    }

    void FixedUpdate()
    {
        Vector3 velocity = _dir.normalized * _speed;
        velocity.y = _rb.velocity.y;
        _rb.velocity = velocity;
    }

    void LateUpdate()
    {
        if(_ani)
        {
            Vector3 walkSpeed = _rb.velocity;
            _ani.SetFloat("Speed", walkSpeed.magnitude);
            Debug.Log("a");
        }
    }

    //カプセル化
    public float Speed
    {
        get { return _speed; }
        set { _speed = value; }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayeMmovement : MonoBehaviour
{
    [SerializeField]
    private float _speed; // ��������(���������) ��������� ������

    [SerializeField]
    private Vector3 _direction; // ����������� �������� ��������� ������

    // Start is called before the first frame update
    private void Start()
    {
        
    }

    // Update is called once per frame
    private void Update()
    {
        _direction.x = Input.GetAxis("Horizontal");
       // _direction.x = Input.GetAxis("Mouse X");

        _direction.z = Input.GetAxis("Vertical");
       // _direction.z = Input.GetAxis("Mouse Z");
    }

    private void FixedUpdate()
    {
        var speed = _direction * _speed * Time.deltaTime;
        transform.Translate(speed);
    }
}

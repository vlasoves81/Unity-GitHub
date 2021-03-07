using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    public void Awake()
    {

    }

    public float _speed;

    [SerializeField]
    private GameObject _testSphere;

    [SerializeField]
    private Transform _spawnPoint;

    // Start is called before the first frame update
    public void Start()
    {
        
        Instantlate(_testSphere, _spawnPoint.position, Quaternion.identity); 
    }

    public void FixedUpdate()
    {

    }
    // Update is called once per frame
    public void Update()
    {
        
    }

    public void LateUpdate()
    {

    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CountDown : MonoBehaviour
{
    [SerializeField] float _Time = 3;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        _Time = Time.deltaTime;
    }
}

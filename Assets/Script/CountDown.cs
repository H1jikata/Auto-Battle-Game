using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

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

    void Countdown()
    {
        _Time--;
        GetComponent<Text>().text = _Time.ToString("F2");
        if (_Time >= 0)
        {
            this.gameObject.SetActive(false);
        }
    }
}

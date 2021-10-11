using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoBattle : MonoBehaviour
{
    [SerializeField] GameObject m_target = null;
    float m_time = 0;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        m_time += Time.deltaTime;
    }
}

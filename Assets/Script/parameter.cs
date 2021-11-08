using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "GameParameter", menuName = "GameParameter")]
public class parameter : ScriptableObject
{
    [SerializeField] int _hp;
    [SerializeField] int _power;
    [SerializeField] int _def;
    [SerializeField] float _ultTime;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public int HP
    {
        get { return _hp; }
    }

    public int Power
    {
        get { return _power; }
    }

    public int Defense
    {
        get { return _def; }
    }

    public float Ult
    {
        get { return _ultTime; }
    }
}

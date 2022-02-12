using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HPBERcon : MonoBehaviour
{
    [SerializeField] Canvas _canvas = default;
    // Update is called once per frame
    void Update()
    {
        _canvas.transform.rotation = Camera.main.transform.rotation;
    }
}

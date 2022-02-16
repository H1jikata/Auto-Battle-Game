using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyObject : MonoBehaviour
{
    [SerializeField] float _reset = 1;
    void Start()
    {
        StartCoroutine(Destroyobj());
    }

    private IEnumerator Destroyobj()
    {
        yield return new WaitForSeconds(_reset);
        Destroy(this.gameObject);
    }
}

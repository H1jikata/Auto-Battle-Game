using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Entrance : MonoBehaviour
{
    [SerializeField] float _time = 1f;
    [SerializeField] string _sceneName = default;
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag =="Player")
        {
            StartCoroutine(Scene());
        }
    }
    IEnumerator Scene()
    {
        yield return new WaitForSeconds(_time);
        SceneManager.LoadScene(_sceneName);
    }

}

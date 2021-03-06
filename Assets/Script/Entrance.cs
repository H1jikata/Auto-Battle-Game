using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Entrance : MonoBehaviour
{
    [SerializeField] float _time = 1f;
    [SerializeField] string _formationScene = "";
    private void OnTriggerEnter(Collider other)
    {
        Scene(_formationScene);
    }

    IEnumerator Scene(string scene)
    {
        yield return new WaitForSeconds(_time);
        SceneManager.LoadScene(scene);
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class Ramuda : MonoBehaviour
{
    List<string> _playerList = new List<string>();
    List<int> _namberList = new List<int>() { 2, 1, 5, 4, 6, 3 };
    void Start()
    {

        _playerList.Add("Maru");
        _playerList.Add("Ran");
        Test();
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    void Test()
    {
        _namberList.OrderBy(i => i > 0).ToList().ForEach((i) => Console.WriteLine(i));
    }
}

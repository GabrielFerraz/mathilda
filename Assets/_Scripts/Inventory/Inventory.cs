using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{

    private List<string> _objects;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _objects = new List<string>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AddObject(GameObject obj)
    {
        _objects.Add(obj.name);
        obj.gameObject.SetActive(false);
        Debug.Log("Objects: " + _objects.ToString());

    }
}

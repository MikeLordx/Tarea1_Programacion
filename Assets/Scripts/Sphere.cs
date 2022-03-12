using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sphere : MonoBehaviour
{
    [SerializeField] private Light _light;
    [SerializeField] private GameObject _sphere;

    void Start()
    {
        GetComponent<Renderer>().material.color = Random.ColorHSV(0f, 1f, 1f, 1f, 0.5f, 1f);
    }

    private void OnTriggerEnter(Collider other)
    {
        _light.color = GetComponent<Renderer>().material.color;
    }

    private void OnTriggerExit(Collider other)
    {
        _light.color = Color.white;
    }
}

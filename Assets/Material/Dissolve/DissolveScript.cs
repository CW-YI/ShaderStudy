using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DissolveScript : MonoBehaviour
{
    [SerializeField, Range(0f, 2f)] float value;

    [SerializeField] Renderer render;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        render.material.SetFloat("_Value", value);
    }
}

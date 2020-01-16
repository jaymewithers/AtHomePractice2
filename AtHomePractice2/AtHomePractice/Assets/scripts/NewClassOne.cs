using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewClassOne : MonoBehaviour
{
    private Renderer _renderer;
    private Renderer _renderer1;
    private Renderer _renderer2;

    // Start is called before the first frame update
    public void Start()
    {
        _renderer2 = GetComponent<Renderer>();
        _renderer1 = GetComponent<Renderer>();
        _renderer = GetComponent<Renderer>();
    }

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            _renderer.material.color = Color.red;
        }
        if (Input.GetKeyDown(KeyCode.G))
        {
            _renderer1.material.color = Color.green;
        }

        if (Input.GetKeyDown(KeyCode.B))
        {
            _renderer2.material.color = Color.blue;
        }
    }
}

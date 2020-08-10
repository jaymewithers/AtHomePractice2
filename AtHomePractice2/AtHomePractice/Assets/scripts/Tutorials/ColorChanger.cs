using UnityEngine;

public class ColorChanger : MonoBehaviour
{
    private Renderer colorObj;

    private void Start()
    {
        colorObj = GetComponent<Renderer>();
    }

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            colorObj.material.color = Color.red;
        }
        if (Input.GetKeyDown(KeyCode.G))
        {
            colorObj.material.color = Color.green;
        }
        if (Input.GetKeyDown(KeyCode.B))
        {
            colorObj.material.color = Color.blue;
        }

        if (Input.GetKeyDown(KeyCode.Y))
        {
            colorObj.material.color = Color.yellow;
        }
    }
}
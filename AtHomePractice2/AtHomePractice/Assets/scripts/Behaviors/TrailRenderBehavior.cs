using UnityEngine;

[RequireComponent(typeof(TrailRenderer))]
public class TrailRenderBehavior : MonoBehaviour
{
    private TrailRenderer trailRenderObj;
    public Material trailRenderMaterial;
    
    void Start()
    {
        trailRenderObj = GetComponent<TrailRenderer>();
        trailRenderObj.time = 2f;
        trailRenderObj.endWidth = 0.1f;
        trailRenderObj.startWidth = 2f;
        trailRenderMaterial.color = Color.white;
    }


    private void Update()
    {
        if (Input.GetKey(KeyCode.B))
        {
            trailRenderMaterial.color = Color.blue;
        }

        if (Input.GetKey(KeyCode.G))
        {
            trailRenderMaterial.color = Color.green;
        }
    }
}
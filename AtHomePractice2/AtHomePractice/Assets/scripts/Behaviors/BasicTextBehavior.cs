using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Text))]
public class BasicTextBehavior : MonoBehaviour
{
    private Text textObj;
    public IntData dataObj;

    private void Start()
    {
        textObj = GetComponent<Text>();
    }

    private void Update()
    {
        textObj.text = dataObj.value.ToString();
    }
}
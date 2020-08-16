using UnityEngine;

[CreateAssetMenu]
public class Collectable : ScriptableObject
{
    public int powerLevel = 10;
    public Color collectableColor = Color.green;
    public Sprite collectableSprite;
}
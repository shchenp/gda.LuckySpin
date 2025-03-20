using UnityEngine;

public class Arrow : MonoBehaviour
{
    public string PrizeName { get; private set; }
    
    private void OnTriggerEnter2D(Collider2D other)
    {
        PrizeName = other.name;
    }
}
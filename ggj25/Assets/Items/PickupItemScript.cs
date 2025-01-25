using UnityEngine;

public class PickupItemScript : MonoBehaviour
{
    

    private void OnTriggerEnter2D(Collider2D other)
    {
        Destroy(gameObject);
    }
}
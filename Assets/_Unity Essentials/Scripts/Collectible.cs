using UnityEngine;

public class Collectible : MonoBehaviour
{
    public float rotationSpeed = 0.5f; // Speed of the collectible rotation
    public GameObject onCollectEffect; // Effect to instantiate on collection

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, rotationSpeed, 0);

    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") == false)
        {
            return; // Exit if the collider is not tagged as "Player"
        } 
        
        // Destroy the collectible when a player collides with it
        Destroy(gameObject);

        // Instantiate the collection effect at the collectible's position and rotation
        if (onCollectEffect != null)
        {
            Instantiate(onCollectEffect, transform.position, transform.rotation);
        }
                
    }
}

using UnityEngine;

public class medusaDetection : MonoBehaviour
{
    public Transform medusa;
    public float medusaDetectionRange = 5f; 
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float distance = Vector2.Distance(transform.position, medusa.position); //Vector2.Distance this calculates distance between two positions
        
        if(distance < medusaDetectionRange)
        {
            Debug.Log("Medusa is nearby!"); 
        }
    }
}

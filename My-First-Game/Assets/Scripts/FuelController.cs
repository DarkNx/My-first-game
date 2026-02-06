using UnityEngine;

public class FuelController : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision collision)
    {
        // Checks for gameObject with name "Car"
        if (collision.gameObject.name == "Car")
        {
            Debug.Log("Meow");
            //If gameObject name matches destroy
            Destroy(gameObject);
        }

    }
}

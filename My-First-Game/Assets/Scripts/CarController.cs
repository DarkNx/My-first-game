using UnityEngine;

public class CarController : MonoBehaviour
{
    //Gets Horizontal and Vertical Input
    private float horizontalInput;
    private float verticalInput;
    //Sets the Speed and TurnSpeed
    public float speed = 10f;
    public float turnSpeed = 30f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Turns the inputs in to corresponding axis
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
        //Makes the car drive
        transform.Translate(Vector3.forward * speed * Time.deltaTime * verticalInput);
        //Makes the car turn
        transform.Rotate(Vector3.up * turnSpeed * Time.deltaTime * horizontalInput);
    }
}

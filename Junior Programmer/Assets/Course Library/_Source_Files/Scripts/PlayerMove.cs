using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }


	public float speed = 20;
	public float turnSpeed;
	public float horizontalInput;
	public float forwardInput;
    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
	forwardInput = Input.GetAxis("Vertical");

	// Move the vehicle forward
	transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
	transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * horizontalInput);
    }
}

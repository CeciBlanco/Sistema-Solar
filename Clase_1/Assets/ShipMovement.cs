using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipMovement : MonoBehaviour
{
    public float horizontal;
    public float vertical;
    public float speed;

    public float rotationSpeed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");


        transform.position += transform.forward * vertical * speed * Time.deltaTime;

        transform.Rotate(Vector3.up, horizontal * rotationSpeed * Time.deltaTime);
    }
}

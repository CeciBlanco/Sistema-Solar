using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Orbitar : MonoBehaviour
{
    Vector3 axisDeRotacion = new Vector3(0, 1, 0);

    public Transform Pivot;
    public float velocidadDeRotacion = 1;

    // Start is called before the first frame update
    void Start()
    {
        
    }
    public float velocidad;
    public float acceleration;
    public float horizontal;
    public float vertical;

    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");
        velocidad += Input.GetAxis("Horizontal") * acceleration;

        transform.RotateAround(Pivot.position, axisDeRotacion, velocidadDeRotacion * Time.deltaTime);
       
        
    }
}

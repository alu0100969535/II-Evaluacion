using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento : MonoBehaviour
{
    public float movementSpeed = 10.0f;

    //Axis - configure in Unity > Exit > Project Settings
    public string verticalAxisName = "Vertical";
    public string horizontalAxisName = "Horizontal";
    //Values
    public float VerticalAxis;
    public float HorizontalAxis;
	
	public Rigidbody rb;

    void Start()
    {
		rb = GetComponent<Rigidbody>();
    }
    // Update is called once per frame
    void FixedUpdate()
    {
        VerticalAxis = Input.GetAxis(verticalAxisName);
        HorizontalAxis = Input.GetAxis(horizontalAxisName);
        /*  Vertical axis: W-S (Forward, backward)
         *  Horizontal axis: A-D (Left, Right)
         */
        float vertical = VerticalAxis * movementSpeed;// * Time.deltaTime;
        float horizontal = HorizontalAxis * movementSpeed;// * Time.deltaTime;
		Vector3 force = new Vector3(horizontal, 0, vertical);
		rb.AddRelativeForce(force);
        //this.transform.Translate(horizontal, 0, vertical);

    }
}

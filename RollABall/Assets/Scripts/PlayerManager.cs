using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;


public class PlayerManager : MonoBehaviour
{
    private Rigidbody rb;

    private float movementX;
    private float movementY;
    private float speed;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();

        movementX = 0f;
        movementY = 0f;
        speed = 10f;
}

    // Update is called once per frame
    void Update()
    {
        // MONTRER CECI EN 1
        //float moveHorizontal = Input.GetAxis("Horizontal");
        //float moveVertical = Input.GetAxis("Vertical");
        //Vector3 movement = new Vector3(moveHorizontal, 0, moveVertical);
        //this.transform.position += movement * Time.deltaTime * 10;

    }

    // MONTRER CECI EN 3
    private void OnMove(InputValue movementValue)
    {
        Vector2 movementVector = movementValue.Get<Vector2>();
        movementX = movementVector.x;
        movementY = movementVector.y;

    }

    private void FixedUpdate()
    {     
        rb.AddForce(movementX * speed,0,movementY * speed);
    }

    // MONTRER CECI EN 2
    //private void FixedUpdate()
    //{
    //    float moveHorizontal = Input.GetAxis("Horizontal");
    //    float moveVertical = Input.GetAxis("Vertical");
    //    Vector3 movement = new Vector3(moveHorizontal, 0, moveVertical);
    //    rb.AddForce(movement * 10);
    //}


}

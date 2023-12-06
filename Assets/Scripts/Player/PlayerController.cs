using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private Rigidbody playerRb;
    [SerializeField] private float verticalInput;
    [SerializeField] private float horizontalInput;

    private void Start()
    {
        playerRb = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        verticalInput = Input.GetAxis("Vertical");
        playerRb.AddRelativeForce(Vector3.forward * speed * Time.deltaTime * verticalInput);

        horizontalInput = Input.GetAxis("Horizontal");
        playerRb.AddRelativeForce(Vector3.right * speed * Time.deltaTime * horizontalInput);
    }
}

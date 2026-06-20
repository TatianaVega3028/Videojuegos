using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class PlayerMovement : MonoBehaviour
{
    public float playerSpeed = 6;
    public float horizontalSpeed = 3;
    public float rightLimit = 5.5f;
    public float leftLimit = -5.5f;

    [Header("Ajustes de Salto")]
    public float jumpForce = 7f;
    public float fallMultiplier = 2.5f; 

    private bool isGrounded = true;
    private Rigidbody rb;

    [SerializeField] bool isRunning;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        // Sistema de distancia
        if (isRunning == false)
        {
            isRunning = true;
            StartCoroutine(AddDistance());
        }

        
        transform.Translate(Vector3.forward * Time.deltaTime * playerSpeed, Space.World);

        
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            if (this.gameObject.transform.position.x > leftLimit)
            {
                transform.Translate(Vector3.left * Time.deltaTime * horizontalSpeed);
            }
        }

        
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            if (this.gameObject.transform.position.x < rightLimit)
            {
                transform.Translate(Vector3.left * Time.deltaTime * horizontalSpeed * -1);
            }
        }

        
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            
            rb.velocity = new Vector3(rb.velocity.x, 0f, rb.velocity.z);
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            isGrounded = false;
        }
    }

    
    void FixedUpdate()
    {
        
        if (rb.velocity.y < 0)
        {
            
            rb.velocity += Vector3.up * Physics.gravity.y * (fallMultiplier - 1) * Time.fixedDeltaTime;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        isGrounded = true;
    }

    IEnumerator AddDistance()
    {
        yield return new WaitForSeconds(0.35f);
        MasterInfo.distanceRun += 1;
        isRunning = false;
    }
}
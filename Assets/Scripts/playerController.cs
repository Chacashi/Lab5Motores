using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class playerController : MonoBehaviour
{
    Rigidbody _compRigidbody;
    float horizontal;
    float vertical;
    public float speed;
    [SerializeField] float xMin, xMax, zMin, zMax;
    [SerializeField] float currentX, currentZ;

    private void Awake()
    {
        _compRigidbody = GetComponent<Rigidbody>();
    }

    private void Start()
    {
    }
    private void Update()
    {
        currentX = Mathf.Clamp(transform.position.x, xMin, xMax);
        currentZ = Mathf.Clamp(transform.position.z, zMin, zMax);
        transform.position = new Vector3(currentX,transform.position.y, currentZ);
    }


    public void AxisX(InputAction.CallbackContext context)
    {
        horizontal = context.ReadValue<float>();
    }


    public void AxisZ(InputAction.CallbackContext context)
    {
        vertical = context.ReadValue<float>();
    }




    private void FixedUpdate()
    {
        _compRigidbody.velocity = new Vector3(speed * horizontal, _compRigidbody.velocity.y, vertical * speed);

    }


  
}

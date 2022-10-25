using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSFX : MonoBehaviour
{
    private AudioSource walking;
    private Rigidbody RB;
    private bool IsMoving;
    private Vector3 currentPos;
    private Vector3 lastPos;
    [SerializeField] Transform groundCheck;
    [SerializeField] LayerMask groundLayer;
    void Start()
    {
        IsMoving = false;
        RB = GetComponent<Rigidbody>();
        walking = GetComponent<AudioSource>();
        walking.Play();
    }
    Vector3 Movement()
    {
        //player input
        float X = Input.GetAxis("Horizontal");
        float Z = Input.GetAxis("Vertical");
        return transform.right * X + transform.forward * Z;
    }
    void Update()
    {
        Vector3 movement = Movement();
        Debug.Log(movement);
        if (!Physics.CheckSphere(groundCheck.position, 1, groundLayer) || movement.x == 0.0f && movement.z == 0.0f)
        {
            walking.Pause();
        }
        else
        {
            walking.UnPause();
        }
    }
}
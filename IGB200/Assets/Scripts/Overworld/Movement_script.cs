using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement_script : MonoBehaviour
{
    private Rigidbody RB;

    [SerializeField] private float speed;
    [SerializeField] private int jumpHeight;

    private float t;

    [SerializeField] Transform groundCheck;
    [SerializeField] LayerMask groundLayer;

    // Start is called before the first frame update
    void Start()
    {
        t = 0;
        RB = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 move = Movement();

        Vector3 jump = Jump();

        PlayerMove(move, jump);
    }

    void PlayerMove(Vector3 move, Vector3 jump)
    {
        //move object
        RB.MovePosition(RB.position + move * Time.deltaTime * speed);
        //jump
        RB.AddForce(jump, ForceMode.Impulse);
    }

    Vector3 Movement()
    {
        //player input
        float X = Input.GetAxis("Horizontal");
        float Z = Input.GetAxis("Vertical");
        return transform.right * X + transform.forward * Z;
    }

    Vector3 Jump()
    {
        t += Time.deltaTime;
        //jump
        if (Input.GetButtonDown("Jump") && Physics.CheckSphere(groundCheck.position, 1, groundLayer))
        {
            t = 0;
            return new Vector3(0, jumpHeight, 0);
        }
        else if (!Physics.CheckSphere(groundCheck.position, 1, groundLayer) && t > 0.3f)
        {
            return new Vector3(0, -0.2f, 0);
        }
        return new Vector3(0, 0, 0);
    }
}

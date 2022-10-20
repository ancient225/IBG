using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement_script : MonoBehaviour
{
    private Rigidbody RB;

    [SerializeField] private float speed;
    [SerializeField] private int jumpHeight;

    [SerializeField] private GameObject Normal;
    [SerializeField] private GameObject Pause;

    private bool pause;

    private float t;

    [SerializeField] Transform groundCheck;
    [SerializeField] LayerMask groundLayer;

    // Start is called before the first frame update
    void Start()
    {
        t = 0;
        RB = GetComponent<Rigidbody>();
        pause = false;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 move = Movement();

        Vector3 jump = Jump();
        
        Buttons();

        PlayerMove(move, jump);
    }

    void Buttons()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (pause)
            {
                Time.timeScale = 1.0f;
                Cursor.lockState = CursorLockMode.Locked;
                Pause.SetActive(false);
                Normal.SetActive(true);
                gameObject.GetComponent<Rigidbody>().velocity = new Vector3(0, 0, 0);
                gameObject.GetComponent<Rigidbody>().useGravity = false;
            }
            else
            {
                Time.timeScale = 0.0f;
                Cursor.lockState = CursorLockMode.None;
                Pause.SetActive(true);
                Normal.SetActive(false);
                gameObject.GetComponent<Rigidbody>().velocity = new Vector3(0, 0, 0);
                gameObject.GetComponent<Rigidbody>().useGravity = false;
            }
            pause = !pause;
        }
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

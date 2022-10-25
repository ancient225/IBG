using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformerMove2D : MonoBehaviour
{
    private Rigidbody RB;

    [SerializeField] private float speed;
    [SerializeField] private int jumpHeight;
    [HideInInspector] public bool Bounce;

    private float t;

    [SerializeField] Transform groundCheck;
    [SerializeField] LayerMask groundLayer;

    [SerializeField] private GameObject End;
    [SerializeField] private GameObject Normal;
    [SerializeField] private GameObject Pause;

    [HideInInspector] public bool pause;

    // Start is called before the first frame update
    void Start()
    {
        t = 0;
        Bounce = false;
        RB = GetComponent<Rigidbody>();
        pause = false;
    }

    // Update is called once per frame
    void Update()
    {
        Buttons();

        if (!pause)
        {
            Vector3 move = Movement();

            Vector3 jump = Jump();

            PlayerMove(move, jump);
        }
    }

    void Buttons()
    {
        if (Input.GetKeyDown(KeyCode.Escape) && End.activeInHierarchy != true)
        {
            if (pause)
            {
                Time.timeScale = 1.0f;
                Cursor.lockState = CursorLockMode.Locked;
                Pause.SetActive(false);
                Normal.SetActive(true);
            }
            else
            {
                Time.timeScale = 0.0f;
                Cursor.lockState = CursorLockMode.None;
                Pause.SetActive(true);
                Normal.SetActive(false);
            }
            pause = !pause;
        }
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
        if (Input.GetButtonDown("Jump") && Physics.CheckSphere(groundCheck.position, 1, groundLayer) || Input.GetKeyDown("w") && Physics.CheckSphere(groundCheck.position, 1, groundLayer))
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

    void PlayerMove(Vector3 move, Vector3 jump)
    {
        //move object
        RB.MovePosition(RB.position + move * Time.deltaTime * speed);
        //jump
        RB.AddForce(jump, ForceMode.Impulse);
    }
}

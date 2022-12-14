using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayermoveSnake : MonoBehaviour
{

    private float t = 0;
    [HideInInspector] public Vector3 Direction;
    private bool startMove;
    [HideInInspector] private Vector3[] Tails = new Vector3[500];
    [HideInInspector] public GameObject[] AllTails = new GameObject[500];
    private Vector3[] TailDirection = new Vector3[500];
    [HideInInspector] public int tails = 0;
    [SerializeField] private bool ShowFace;
    private int xface;
    private Vector3 face;

    [SerializeField] private GameObject Pause;
    [SerializeField] private GameObject End;
    [SerializeField] private GameObject Normal;

    [HideInInspector] public bool pause;


    // Start is called before the first frame update
    void Start()
    {
        if (ShowFace)
        {
            xface = 180;
        }
        else
        {
            xface = 0;
        }
        Direction = new Vector3(1, 0, 0);
        startMove = false;
        pause = false;
    }

    // Update is called once per frame
    void Update()
    {
        Buttons();

        if (!pause)
        {

            if (Input.GetAxis("Horizontal") != 0 && !startMove || Input.GetAxis("Vertical") != 0 && !startMove)
            {
                setDirection();
                startMove = true;
            }
            if (startMove)
            {
                t += Time.deltaTime;
                if (t > 0.3)
                {
                    t = 0;
                    move();

                    Tails[0] = transform.position;
                    TailDirection[0] = Direction;



                    for (int i = 1; i < tails + 1; i++)
                    {
                        Tails[i] = Tails[i - 1] - TailDirection[i - 1];
                    }


                    for (int i = 1; i < tails + 1; i++)
                    {
                        AllTails[i].transform.position = Tails[i];
                        if (TailDirection[i].y == 1)
                        {
                            AllTails[i].GetComponent<wobble>().Direction = 90;
                        }
                        else if (TailDirection[i].y == -1)
                        {
                            AllTails[i].GetComponent<wobble>().Direction = 270;
                        }
                        else if (TailDirection[i].x == 1)
                        {
                            AllTails[i].GetComponent<wobble>().Direction = 5;
                        }
                        else if (TailDirection[i].x == -1)
                        {
                            AllTails[i].GetComponent<wobble>().Direction = 180;
                        }
                    }

                    for (int i = tails + 1; i > 0; i--)
                    {
                        TailDirection[i] = TailDirection[i - 1];
                    }
                }

                ChangeDirection();
            }


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

    void setDirection()
    {
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");

        if (x > 0)
        {
            face = new Vector3(xface, 0, 180);
            Direction.y = 0;
            Direction.x = 1;
        }
        if (x < 0)
        {
            face = new Vector3(xface, 0, 0);
            Direction.y = 0;
            Direction.x = -1;
        }
        if (y > 0)
        {
            face  = new Vector3(xface, 0, -90 + xface);
            Direction.y = 1;
            Direction.x = 0;
        }
        if (y < 0)
        {
            face = new Vector3(xface, 0, 90 + xface);
            Direction.y = -1;
            Direction.x = 0;
        }
    }

    void ChangeDirection()
    {
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");
        

        if (x > 0 && Direction.x == 0)
        {
            face = new Vector3(xface, 0, 180);
            Direction.y = 0;
            Direction.x = 1;
        }
        if (x < 0 && Direction.x == 0)
        {
            face = new Vector3(xface, 0, 0);
            Direction.y = 0;
            Direction.x = -1;
        }
        if (y > 0 && Direction.y == 0)
        {
            face = new Vector3(xface, 0, -90 + xface);
            Direction.y = 1;
            Direction.x = 0;
        }
        if (y < 0 && Direction.y == 0)
        {
            face = new Vector3(xface, 0, 90 + xface);
            Direction.y = -1;
            Direction.x = 0;
        }
    }

    void move()
    {
        Vector3 pos = transform.position;

        pos.x += Direction.x;
        pos.y += Direction.y;
        transform.eulerAngles = face;

        transform.position = pos;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Collision : MonoBehaviour
{
    [SerializeField] private GameObject Player;
    [SerializeField] private GameObject Text;
    [SerializeField] private GameObject Ballholder;
    [SerializeField] private GameObject BallOne;
    [SerializeField] private GameObject BallTwo;
    [SerializeField] private GameObject BallThree;
    [SerializeField] private GameObject Basket;
    private GameObject current;
    private bool throwBall;
    private int UI2;
    private float t = 0;

    private void Start()
    {
        throwBall = true;
    }

    void hold()
    {
        if (current != null)
        {
            current.GetComponent<Rigidbody>().useGravity = false;
            current.GetComponent<Rigidbody>().velocity = new Vector3 (0, 0, 0);

            current.transform.position = Ballholder.transform.position;
            current.transform.parent = Ballholder.transform;

            if (Input.GetKey("e") && !throwBall)
            {
                current.transform.parent = null;

                current.GetComponent<Rigidbody>().useGravity = true;

                current.GetComponent<Rigidbody>().AddForce(gameObject.transform.forward * 6, ForceMode.Impulse);

                current = null;

                t = 0;
            }

        }

        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        hold();

        t += Time.deltaTime;
        if (current == null && t > 0.5f)
        {
            throwBall = true;
        }
        if (current != null && t > 0.5f)
        {
            //Player.GetComponent<LineScript>().updateTragectory(gameObject.transform.forward * 6, current.GetComponent<Rigidbody>(), Ballholder.transform.position);
            throwBall = false;
        }

        int UI;
        if (Text.GetComponent<Text>().UI != 100)
        {
            UI2 = Text.GetComponent<Text>().UI;
        }

        RaycastHit hit;
        int Bob = 1 << 7;
        int Jenny = 1 << 8;
        int Pete = 1 << 9;
        int Chole = 1 << 10;
        int Fred = 1 << 11;
        int Joel = 1 << 12;
        int Rebecca = 1 << 13;
        int Britney = 1 << 14;
        int Hannah = 1 << 15;
        int Sam = 1 << 16;
        int Tom = 1 << 17;
        int Ball = 1 << 18;
        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, 15, Ball))
        {
            UI = 100;
            if (Input.GetKey("e") && throwBall)
            {
                if (current == null)
                {
                    current = hit.transform.gameObject;
                    t = 0;
                }
            }
        }
        else if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, 15, Bob))
        {
            UI = 100;
            if (Input.GetKey("e"))
            {
                if (UniversalText.story == 0)
                {
                    UniversalText.story = 1;
                }
                Basket.SetActive(true);
                BallOne.SetActive(true);
                BallTwo.SetActive(true);
                BallThree.SetActive(true);
                UI = 90;
            }
        }
        else if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, 15, Pete))
        {
            UI = 100;
            if (Input.GetKey("e"))
            {
                if (UniversalText.story < 1)
                {
                    UI = UniversalText.story + 87;
                }
                else
                {
                    if (UniversalText.story == 1)
                    {
                        UniversalText.story = 2;
                    }
                    SceneManager.LoadScene("Platformer Explained");
                }
            }
        }
        else if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, 15, Fred))
        {
            UI = 100;
            if (Input.GetKey("e"))
            {
                if (UniversalText.story < 2)
                {
                    UI = UniversalText.story + 88;
                }
                else
                {
                    if (UniversalText.story == 2)
                    {
                        UniversalText.story = 3;
                    }
                    SceneManager.LoadScene("Snake Explained");
                }
            }
        }
        else if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, 15, Rebecca))
        {
            UI = 100;
            if (Input.GetKey("e"))
            {
                if (UniversalText.story < 3)
                {
                    UI = UniversalText.story + 89;
                }
                else
                {
                    if (UniversalText.story == 3)
                    {
                        UniversalText.story = 4;
                    }
                    SceneManager.LoadScene("Music Explained");
                }
            }
        }
        else if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, 15, Jenny))
        {
            UI = 100;
            if (Input.GetKey("e"))
            {
                UI = 99;
            }
        }
        else if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, 15, Chole))
        {
            UI = 100;
            if (Input.GetKey("e"))
            {
                UI = 98;
            }
        }
        else if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, 15, Joel))
        {
            UI = 100;
            if (Input.GetKey("e"))
            {
                UI = 97;
            }
        }
        else if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, 15, Britney))
        {
            UI = 100;
            if (Input.GetKey("e"))
            {
                UI = 96;
            }
        }
        else if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, 15, Hannah))
        {
            UI = 100;
            if (Input.GetKey("e"))
            {
                UI = 95;
            }
        }
        else if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, 15, Sam))
        {
            UI = 100;
            if (Input.GetKey("e"))
            {
                UI = 94;
            }
        }
        else if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, 15, Tom))
        {
            UI = 100;
            if (Input.GetKey("e"))
            {
                UI = 93;
            }
        }
        else
        {
            UI = UI2;
        }

        Text.GetComponent<Text>().UI = UI;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Collision : MonoBehaviour
{
    [SerializeField] private GameObject Text;
    private int UI2;

    // Update is called once per frame
    void FixedUpdate()
    {
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
        int Shop = 1 << 18;
        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, 15, Bob))
        {
            UI = 100;
            if (Input.GetKeyDown("e"))
            {
                if (UniversalText.story == 0)
                {
                    UniversalText.story = 1;
                }
                SceneManager.LoadScene("Pong Explained");
            }
        }
        else if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, 15, Pete))
        {
            UI = 100;
            if (Input.GetKeyDown("e"))
            {
                if (UniversalText.story < 1)
                {
                    UI = UniversalText.story + 86;
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
            if (Input.GetKeyDown("e"))
            {
                if (UniversalText.story < 2)
                {
<<<<<<< Updated upstream
                    UI = UniversalText.story + 86;
=======
                    UI = UniversalText.story + 87;
>>>>>>> Stashed changes
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
            if (Input.GetKeyDown("e"))
            {
                if (UniversalText.story < 3)
                {
<<<<<<< Updated upstream
                    UI = UniversalText.story + 86;
=======
                    UI = UniversalText.story + 88;
>>>>>>> Stashed changes
                }
                else
                {
                    if (UniversalText.story == 3)
                    {
                        UniversalText.story = 4;
                    }
                    UI = 91;
                }
            }
        }
        else if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, 15, Shop))
        {
            UI = 100;
            if (Input.GetKeyDown("e"))
            {
                UI = 90;
            }
        }
        else if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, 15, Jenny))
        {
            UI = 100;
            if (Input.GetKeyDown("e"))
            {
                UI = 99;
            }
        }
        else if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, 15, Chole))
        {
            UI = 100;
            if (Input.GetKeyDown("e"))
            {
                UI = 98;
            }
        }
        else if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, 15, Joel))
        {
            UI = 100;
            if (Input.GetKeyDown("e"))
            {
                UI = 97;
            }
        }
        else if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, 15, Britney))
        {
            UI = 100;
            if (Input.GetKeyDown("e"))
            {
                UI = 96;
            }
        }
        else if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, 15, Hannah))
        {
            UI = 100;
            if (Input.GetKeyDown("e"))
            {
                UI = 95;
            }
        }
        else if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, 15, Sam))
        {
            UI = 100;
            if (Input.GetKeyDown("e"))
            {
                UI = 94;
            }
        }
        else if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, 15, Tom))
        {
            UI = 100;
            if (Input.GetKeyDown("e"))
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

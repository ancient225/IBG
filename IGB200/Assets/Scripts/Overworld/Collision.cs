using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Collision : MonoBehaviour
{
    [SerializeField] private GameObject Text;

    // Update is called once per frame
    void FixedUpdate()
    {

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
        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, 15, Bob) && Input.GetButton("Fire1"))
        {
            SceneManager.LoadScene("Pong");
        }
        else if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, 15, Pete) && Input.GetButton("Fire1"))
        {
            SceneManager.LoadScene("Platformer");
        }
        else if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, 15, Fred) && Input.GetButton("Fire1"))
        {
            Text.GetComponent<Text>().UI = 92;
        }
        else if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, 15, Rebecca) && Input.GetButton("Fire1"))
        {
            Text.GetComponent<Text>().UI = 91;
        }
        else if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, 15, Shop) && Input.GetButton("Fire1"))
        {
            Text.GetComponent<Text>().UI = 90;
        }


        else if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, 15, Jenny) && Input.GetButton("Fire1"))
        {
            Text.GetComponent<Text>().UI = 99;
        }
        else if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, 15, Chole) && Input.GetButton("Fire1"))
        {
            Text.GetComponent<Text>().UI = 98;
        }
        else if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, 15, Joel) && Input.GetButton("Fire1"))
        {
            Text.GetComponent<Text>().UI = 97;
        }
        else if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, 15, Britney) && Input.GetButton("Fire1"))
        {
            Text.GetComponent<Text>().UI = 96;
        }
        else if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, 15, Hannah) && Input.GetButton("Fire1"))
        {
            Text.GetComponent<Text>().UI = 95;
        }
        else if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, 15, Sam) && Input.GetButton("Fire1"))
        {
            Text.GetComponent<Text>().UI = 94;
        }
        else if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, 15, Tom) && Input.GetButton("Fire1"))
        {
            Text.GetComponent<Text>().UI = 93;
        }

    }
}

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
        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, 15, Bob) && Input.GetButton("Fire1"))
        {
            SceneManager.LoadScene("Pong");
        }
        else if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, 15, Pete) && Input.GetButton("Fire1"))
        {
            SceneManager.LoadScene("Platformer");
        }


        else if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, 15, Jenny) && Input.GetButton("Fire1"))
        {
            Text.GetComponent<Text>().UI = 99;
        }
        
    }
}

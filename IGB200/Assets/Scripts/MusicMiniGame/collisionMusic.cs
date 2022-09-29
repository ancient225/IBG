using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collisionMusic : MonoBehaviour
{
    private Renderer ren;
    [SerializeField] private Material matOne;
    [SerializeField] private Material matTwo;
    private bool col;

    [SerializeField] private GameObject ENote;
    [SerializeField] private GameObject CNote;
    [SerializeField] private GameObject DNote;

    private void Start()
    {
        col = false;
        ren = gameObject.GetComponent<Renderer>();
    }

    private void Update()
    {
        if (col)
        {
            ren.material = matOne;
        }
        else
        {
            ren.material = matTwo;
        }
    }

    private void OnTriggerStay(Collider other)
    {
        col = true;

        if(other.tag == "E")
        {
            if (Input.anyKey)
            {
                Destroy(other.gameObject);
                col = false;
                Instantiate(ENote);
            }
        }
        else if(other.tag == "C")
        {
            if (Input.anyKey)
            {
                Destroy(other.gameObject);
                col = false;
                Instantiate(CNote);
            }
        }
        else if(other.tag == "D")
        {
            if (Input.anyKey)
            {
                Destroy(other.gameObject);
                col = false;
                Instantiate(DNote);
            }
        }
    }
    private void OnTriggerExit(Collider other)
    {
        col = false;
    }
}

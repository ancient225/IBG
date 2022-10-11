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
    [SerializeField] private GameObject FNote;
    [SerializeField] private GameObject GNote;
    [SerializeField] private GameObject BigGNote;

    private GameObject Holding;
    private string Note;

    private void Set(GameObject hold, string note)
    {
        Holding = hold;
        Note = note;
    }

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

        if (Note != null)
        {
            if (Input.GetKeyDown(Note) && Holding)
            {
                if (Note == "e")
                {
                    Instantiate(ENote);
                }
                else if (Note == "c")
                {
                    Instantiate(CNote);
                }
                else if (Note == "d")
                {
                    Instantiate(DNote);
                }
                else if (Note == "f")
                {
                    Instantiate(FNote);
                }
                else if (Note == "g")
                {
                    if (Holding.tag == "G")
                    {
                        Instantiate(GNote);
                    }
                    else
                    {
                        Instantiate(BigGNote);
                    }
                }
                Destroy(Holding);
                Holding = null;
                col = false;
            }
        }
    }

    private void OnTriggerStay(Collider other)
    {
        col = true;

        if(other.tag == "E")
        {
            if (Holding == null)
            {
                Set(other.gameObject, "e");
            }
        }
        else if(other.tag == "C")
        {
            if (Holding == null)
            {
                Set(other.gameObject, "c");
            }
        }
        else if(other.tag == "D")
        {
            if (Holding == null)
            {
                Set(other.gameObject, "d");
            }
        }
        else if(other.tag == "F")
        {
            if (Holding == null)
            {
                Set(other.gameObject, "f");
            }
        }
        else if(other.tag == "G")
        {
            if (Holding == null)
            {
                Set(other.gameObject, "g");
            }
        }
        else if(other.tag == "BigG")
        {
            if (Holding == null)
            {
                Set(other.gameObject, "g");
            }
        }
    }
    private void OnTriggerExit(Collider other)
    {
        col = false;
    }
}

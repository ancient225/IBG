using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PongControls : MonoBehaviour
{
    [SerializeField] private int speed;

    [SerializeField] private GameObject ENote;
    [SerializeField] private GameObject CNote;
    [SerializeField] private GameObject DNote;
    [SerializeField] private GameObject FNote;
    [SerializeField] private GameObject GNote;
    [SerializeField] private GameObject Score;


    // Update is called once per frame
    void Update()
    {
        Vector3 pos = gameObject.transform.position;

        float Z = Input.GetAxis("Vertical");

        pos.y += Z * Time.deltaTime * speed;

        if(pos.y > 4)
        {
            pos.y = 4;
        }
        else if(pos.y < -4)
        {
            pos.y =-4;
        }

        gameObject.transform.position = pos;

        if (Input.GetKey("escape"))
        {
            Application.Quit();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "E")
        {
            Score.GetComponent<ScorePong>().score += 1;
            Instantiate(ENote);
            Destroy(other.gameObject);
        }
        else if (other.tag == "C")
        {
            Score.GetComponent<ScorePong>().score += 1;
            Instantiate(CNote);
            Destroy(other.gameObject);
        }
        else if (other.tag == "D")
        {
            Score.GetComponent<ScorePong>().score += 1;
            Instantiate(DNote);
            Destroy(other.gameObject);
        }
        else if (other.tag == "F")
        {
            Score.GetComponent<ScorePong>().score += 1;
            Instantiate(FNote);
            Destroy(other.gameObject);
        }
        else if (other.tag == "G")
        {
            Score.GetComponent<ScorePong>().score += 1;
            Instantiate(GNote);
            Destroy(other.gameObject);
        }
    }
}

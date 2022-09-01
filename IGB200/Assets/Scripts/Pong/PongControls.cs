using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PongControls : MonoBehaviour
{
    [SerializeField] private int speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = gameObject.transform.position;

        float Z = Input.GetAxis("Vertical");

        pos.y += Z * Time.deltaTime * speed;

        if(pos.y > 5)
        {
            pos.y = 5;
        }
        else if(pos.y < -3)
        {
            pos.y =-3;
        }

        gameObject.transform.position = pos;

        if (Input.GetKey("escape"))
        {
            Application.Quit();
        }
    }
}

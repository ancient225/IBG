using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class home : MonoBehaviour
{
    private Vector3 homePos;

    // Start is called before the first frame update
    void Start()
    {
        homePos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = transform.position;
        if (Vector3.Distance(pos, homePos) > 50)
        {
            pos = homePos;
        }
        transform.position = pos;
    }
}

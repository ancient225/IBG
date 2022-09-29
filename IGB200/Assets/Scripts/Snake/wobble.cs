using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wobble : MonoBehaviour
{
    [HideInInspector] public int Direction;
    [HideInInspector] public GameObject player;

    // Update is called once per frame
    void Update()
    {
        if (player != null)
        {

            Vector3 rot = transform.eulerAngles;

            if (transform.eulerAngles.z < Direction)
            {
                rot.z += 1000 * Time.deltaTime;
            }
            else
            {
                rot.z -= 1000 * Time.deltaTime;
            }

            transform.eulerAngles = rot;
        }
    }
}

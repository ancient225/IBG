using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveMusic : MonoBehaviour
{
    [SerializeField] private int speed;
    [SerializeField] private GameObject control;

    private void Update()
    {
        if (!control.GetComponent<ControlMusic>().pause)
        {
            Vector3 pos = transform.position;

            pos.x -= speed * Time.deltaTime;

            transform.position = pos;
        }
    }
}

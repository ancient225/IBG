using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAtPlayer : MonoBehaviour
{
    [SerializeField] private Camera playerCamera;

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.LookAt(playerCamera.transform.position);
        gameObject.transform.Rotate(0, 180, 0);
    }
}

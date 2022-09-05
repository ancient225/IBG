using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAtPlayer : MonoBehaviour
{
    [SerializeField] private Camera playerCamera;

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(playerCamera.transform.position);
        Quaternion Rot = transform.rotation;

        Rot = new Quaternion(0, Rot.y, 0, Rot.w);

        transform.rotation = Rot;
    }
}

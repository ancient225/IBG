using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour
{
    [SerializeField] private GameObject miniGame;

    // Update is called once per frame
    void FixedUpdate()
    {

        int NPCOne = 1 << 7;
        RaycastHit hit;
        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, 15, NPCOne) && Input.GetButton("Fire1"))
        {
            Time.timeScale = 0.0f;
            Cursor.lockState = CursorLockMode.None;
            miniGame.SetActive(true);
        }
    }
}

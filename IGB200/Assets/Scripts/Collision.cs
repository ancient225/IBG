using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour
{
    [SerializeField] private GameObject miniGame;
    [SerializeField] private GameObject Control;

    // Update is called once per frame
    void FixedUpdate()
    {

        int NPCOne = 1 << 7;
        RaycastHit hit;
        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, 15, NPCOne) && Input.GetButton("Fire1"))
        {
            Time.timeScale = 0.0f;
            Cursor.lockState = CursorLockMode.None;

            Control.GetComponent<control>().UI = 1;

            gameObject.transform.position = new Vector3 (0, 10, 0);
            gameObject.transform.rotation = new Quaternion (0, 0, 0, 0);
            
            miniGame.SetActive(true);
        }
    }
}

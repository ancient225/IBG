using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerView : MonoBehaviour
{
    private float rotationY;
    private Vector2 mouseDirection;
    [SerializeField] private float sensitivity;
    [SerializeField] private Transform Player;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }
    void Update()
    {
        mouseDirection.x += Input.GetAxis("Mouse X") * sensitivity * Time.deltaTime;
        mouseDirection.y = Input.GetAxis("Mouse Y") * sensitivity * Time.deltaTime;

        rotationY -= mouseDirection.y;
        rotationY = Mathf.Clamp(rotationY, -15.0f, 45.0f);

        gameObject.transform.localRotation = Quaternion.Euler(rotationY, 0.0f, 0.0f);
        Player.localRotation = Quaternion.Euler(0.0f, mouseDirection.x, 0.0f);
    }
}
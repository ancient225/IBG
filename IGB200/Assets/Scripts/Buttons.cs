using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Buttons : MonoBehaviour
{
    [SerializeField] private GameObject MiniGame;

    [SerializeField] private GameObject Player;

    [SerializeField] private GameObject Control;

    public void EndMiniGame()
    {
        Time.timeScale = 1.0f;
        Cursor.lockState = CursorLockMode.Locked;

        Control.GetComponent<control>().UI = 2;

        MiniGame.SetActive(false);

        Player.transform.position = new Vector3(0, 10, 0);
        Player.GetComponent<Rigidbody>().velocity = new Vector3(0, 0, 0);
    }
}

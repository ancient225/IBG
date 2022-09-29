using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerCollisionSnake : MonoBehaviour
{

    [SerializeField] private GameObject AppleSpawner;
    [SerializeField] private GameObject Score;
    [SerializeField] private GameObject Tail;
    [SerializeField] private GameObject End;

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "apple")
        {
            Destroy(other.gameObject);
            GameObject NEW = Instantiate(Tail, new Vector3 (100, 100, 100), new Quaternion(0, 0, 0, 0));
            NEW.GetComponent<wobble>().player = gameObject;
            GetComponent<PlayermoveSnake>().tails += 1;
            GetComponent<PlayermoveSnake>().AllTails[GetComponent<PlayermoveSnake>().tails] = NEW;
            UniversalText.Points += 1;
            Score.GetComponent<ScorePong>().score += 1;
        }
    }

    private void OnCollisionEnter(UnityEngine.Collision collision)
    {
        GameObject[] alltails = GameObject.FindGameObjectsWithTag("tail");
        foreach (GameObject tail in alltails)
        {
            tail.GetComponent<Rigidbody>().useGravity = true;
        }
        Destroy(gameObject);
        Cursor.lockState = CursorLockMode.None;
        End.SetActive(true);
    }
}

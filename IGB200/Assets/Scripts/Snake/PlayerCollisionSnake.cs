using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerCollisionSnake : MonoBehaviour
{

    [SerializeField] private GameObject AppleSpawner;
    [SerializeField] private GameObject Tail;

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "apple")
        {
            Destroy(other.gameObject);
            GameObject NEW = Instantiate(Tail, new Vector3 (100, 100, 100), new Quaternion(0, 0, 0, 0));
            GetComponent<PlayermoveSnake>().tails += 1;
            GetComponent<PlayermoveSnake>().Back[GetComponent<PlayermoveSnake>().tails] = NEW;
            UniversalText.Points += 1;
        }
        else
        {
            SceneManager.LoadScene("IGB200");
        }
    }
}

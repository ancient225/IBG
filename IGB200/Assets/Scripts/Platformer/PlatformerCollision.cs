using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlatformerCollision : MonoBehaviour
{

    [SerializeField] private GameObject Score;
    [SerializeField] private GameObject Panel;
    [SerializeField] private GameObject Virus;
    [SerializeField] private GameObject End;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("escape"))
        {
            Application.Quit();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Spike")
        {
            UniversalText.Points += Score.GetComponent<ScorePong>().score;
            Time.timeScale = 0.0f;
            Cursor.lockState = CursorLockMode.None;
            Panel.SetActive(false);
            End.SetActive(true);
        }
        else if(other.tag == "Coin")
        {
            Instantiate(Virus, other.transform.position, new Quaternion(0, 0, 0, 0));
            Score.GetComponent<ScorePong>().score += 1;
            Destroy(other.gameObject);
        }
    }
}

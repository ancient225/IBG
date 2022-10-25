using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlatformerCollision : MonoBehaviour
{

    [SerializeField] private GameObject Score;
<<<<<<< Updated upstream
    [SerializeField] private int bounce;
=======
    [SerializeField] private GameObject Virus;
    [SerializeField] private GameObject End;
    [SerializeField] public AudioSource coinsfx;
>>>>>>> Stashed changes

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
<<<<<<< Updated upstream
            SceneManager.LoadScene("Platformer");
        }
        else if(other.tag == "Coin")
        {
=======
            UniversalText.Points += Score.GetComponent<ScorePong>().score;
            Time.timeScale = 0.0f;
            Cursor.lockState = CursorLockMode.None;
            End.SetActive(true);
        }
        else if(other.tag == "Coin")
        {
            coinsfx.Play();
            Instantiate(Virus, other.transform.position, new Quaternion(0, 0, 0, 0));
            Score.GetComponent<ScorePong>().score += 1;
>>>>>>> Stashed changes
            Destroy(other.gameObject);
            Score.GetComponent<ScorePong>().score += 1;
        }
        else if(other.tag == "Bounce")
        {
            gameObject.GetComponent<Rigidbody>().velocity = new Vector3 (0, 0, 0);
            gameObject.GetComponent<Rigidbody>().AddForce(new Vector3(0, bounce, 0), ForceMode.Impulse);
        }
    }
}

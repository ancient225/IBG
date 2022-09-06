using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlatformerCollision : MonoBehaviour
{

    [SerializeField] private GameObject Score;
    [SerializeField] private int bounce;

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
            SceneManager.LoadScene("Platformer");
        }
        else if(other.tag == "Coin")
        {
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

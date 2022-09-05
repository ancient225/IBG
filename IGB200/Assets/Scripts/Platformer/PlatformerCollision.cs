using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlatformerCollision : MonoBehaviour
{

    [SerializeField] private GameObject Score;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
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
            gameObject.GetComponent<PlatformerMove2D>().Bounce = true;
        }
    }
}

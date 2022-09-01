using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallStart : MonoBehaviour
{
    [HideInInspector] public Vector3 Move;
    [SerializeField] private float speed;
    [SerializeField] private GameObject Score;

    // Start is called before the first frame update
    void Start()
    {
        Moving();
    }

    void Moving()
    {
        if(Random.value > 0.5)
        {
            Move.x = speed + (Random.value - 0.5f) * 2;
        }
        else
        {
            Move.x = -speed + (Random.value - 0.5f) * 2;
        }
        
        if(Random.value > 0.5)
        {
            Move.y = speed + (Random.value - 0.5f) * 2;
        }
        else
        {
            Move.y = -speed + (Random.value - 0.5f) * 2;
        }
    }

    // Update is called once per frame
    void Update()
    {
        Move.x += Move.x / 10 * Time.deltaTime;

        Vector3 pos = gameObject.transform.position;

        pos += Move * Time.deltaTime;
        pos.z = 0;

        gameObject.transform.position = pos;

        Debug.Log(Move);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "wall")
        {
            Move.y *= -1;
        }
        else if (other.tag == "bat")
        {
            Move.x *= -1;
        }
        else if (other.tag == "EnemeyGoal")
        {
            gameObject.transform.position = new Vector3(0, 0, 0);
            Score.GetComponent<ScorePong>().score -= 1;
            Moving();
        }
        else
        {
            gameObject.transform.position = new Vector3(0, 0, 0);
            Score.GetComponent<ScorePong>().score += 1;
            Moving();
        }
    }
}

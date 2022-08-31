using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallStart : MonoBehaviour
{
    [HideInInspector] public Vector3 Move;
    // Start is called before the first frame update
    void Start()
    {
        Moving();
    }

    void Moving()
    {
        Move = new Vector3(Mathf.RoundToInt(Random.Range(-5, 5)), Mathf.RoundToInt(Random.Range(-5, 5)), 0);
        if (Mathf.Abs(Move.x) < 3)
        {
            Move.x *= 3;
        }
        if (Mathf.Abs(Move.y) < 3)
        {
            Move.y *= 3;
        }
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = gameObject.transform.position;

        pos += Move * Time.deltaTime;
        pos.z = 0;

        gameObject.transform.position = pos;
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
        else
        {
            gameObject.transform.position = new Vector3(0, 0, 0);
            Moving();
        }
    }
}

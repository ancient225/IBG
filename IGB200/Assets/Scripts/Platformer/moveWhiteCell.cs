using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveWhiteCell : MonoBehaviour
{
    [HideInInspector] public Vector3 Move;
    [SerializeField] private float speed;

    // Start is called before the first frame update
    void Start()
    {
        Moving();
    }

    void Moving()
    {
        if (Random.value > 0.5)
        {
            Move.x = speed + (Random.value - 0.5f) * 2;
        }
        else
        {
            Move.x = -speed + (Random.value - 0.5f) * 2;
        }

        if (Random.value > 0.5)
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
        Vector3 pos = gameObject.transform.position;

        pos += Move * Time.deltaTime;
        pos.z = 0;

        gameObject.transform.position = pos;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "backWall")
        {
            Move.x *= -1;
        }
        else
        {
            Move.y *= -1;
        }
    }
}

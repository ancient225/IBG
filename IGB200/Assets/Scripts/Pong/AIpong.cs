using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIpong : MonoBehaviour
{
    [SerializeField] private GameObject Ball;

    [SerializeField] private int speed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 posBall = Ball.transform.position;
        Vector3 pos = gameObject.transform.position;
        
        if(pos.y < posBall.y)
        {
            pos.y += speed * Time.deltaTime;
        }
        else
        {
            pos.y -= speed * Time.deltaTime;
        }

        gameObject.transform.position = pos;
    }
}

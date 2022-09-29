using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveMusic : MonoBehaviour
{
    [SerializeField] private int speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = transform.position;

        pos.x -= speed * Time.deltaTime;

        transform.position = pos;
    }
}

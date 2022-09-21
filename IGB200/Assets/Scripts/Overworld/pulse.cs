using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pulse : MonoBehaviour
{
    private bool down;
    private Vector3 amount = new Vector3(1.5f, 1.5f, 1.5f);

    // Start is called before the first frame update
    void Start()
    {
        down = true;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 scale = transform.localScale;

        if (scale.x < 0.5f || scale.x > 1.5f)
        {
            down = !down;
        }

        if (down)
        {
            scale -= amount * Time.deltaTime;
        }
        else
        {
            scale += amount * Time.deltaTime;
        }

        transform.localScale = scale;
    }
}

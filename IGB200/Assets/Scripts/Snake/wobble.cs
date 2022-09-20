using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wobble : MonoBehaviour
{
    int spin;
    // Start is called before the first frame update
    void Start()
    {
        spin = Random.Range(-45, 45);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, 0, spin * Time.deltaTime);
    }
}

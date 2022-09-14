using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spin : MonoBehaviour
{
    private Vector3 spin;

    // Start is called before the first frame update
    void Start()
    {
        spin = new Vector3(Random.Range(30, 90) * 2, Random.Range(30, 90) * 2, Random.Range(30, 90) * 2);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(spin.x * Time.deltaTime, spin.y * Time.deltaTime, spin.z * Time.deltaTime);
    }
}

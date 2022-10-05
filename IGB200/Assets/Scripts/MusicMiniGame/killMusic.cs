using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class killMusic : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("hit");
        Destroy(other.gameObject);
    }
}

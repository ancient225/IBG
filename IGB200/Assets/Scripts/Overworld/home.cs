using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class home : MonoBehaviour
{
    private Vector3 homePos;
    [SerializeField] private TMPro.TextMeshProUGUI info;

    // Start is called before the first frame update
    void Start()
    {
        homePos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        info.text = "Baskets: " + UniversalText.baskets;

        Vector3 pos = transform.position;
        if (Vector3.Distance(pos, homePos) > 50)
        {
            pos = homePos;
        }
        transform.position = pos;
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "hoop")
        {
            Vector3 pos = transform.position;
            pos = homePos;
            transform.position = pos;

            UniversalText.baskets += 1;
            UniversalText.Points += 1;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoTo : MonoBehaviour
{
    [SerializeField] private GameObject Bob;
    [SerializeField] private GameObject Pete;
    [SerializeField] private GameObject Fred;
    [SerializeField] private GameObject Rebecca;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = transform.position;
        if(UniversalText.story == 0)
        {
            pos = Bob.transform.position;
        }
        else if(UniversalText.story == 1)
        {
            pos = Pete.transform.position;
        }
        else if (UniversalText.story == 2)
        {
            pos = Fred.transform.position;
        }
        else if (UniversalText.story == 3)
        {
            pos = Rebecca.transform.position;
        }
        else
        {
            Destroy(gameObject);
        }
        pos.y = 10;
        transform.position = pos;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlMusic : MonoBehaviour
{
    [SerializeField] private GameObject Music;
    [SerializeField] private GameObject End;
    [SerializeField] private GameObject Panel;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Music.transform.childCount == 0)
        {
            End.SetActive(true);
            Panel.SetActive(false);
        }
    }
}

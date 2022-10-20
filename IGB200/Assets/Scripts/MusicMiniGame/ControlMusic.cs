using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlMusic : MonoBehaviour
{
    [SerializeField] private GameObject Music;
    [SerializeField] private GameObject End;
    [SerializeField] private GameObject Panel;
    [SerializeField] private GameObject Score;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Music.transform.childCount == 0)
        {
            UniversalText.Points += Score.GetComponent<ScorePong>().score;
            End.SetActive(true);
            Panel.SetActive(false);
        }
    }
}

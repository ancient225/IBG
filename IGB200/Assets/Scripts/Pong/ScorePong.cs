using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScorePong : MonoBehaviour
{
    private TMPro.TextMeshProUGUI info;
    [HideInInspector] public int score;
    [SerializeField] private GameObject End;
    [SerializeField] private GameObject Score;
    [SerializeField] private int plat;

    // Start is called before the first frame update
    void Start()
    {
        info = gameObject.GetComponent<TMPro.TextMeshProUGUI>();
        score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if(score <= 0)
        {
            score = 0;
        }
        else if (score > 20 && plat == 1)
        {
            UniversalText.Points += Score.GetComponent<ScorePong>().score;
            Time.timeScale = 0.0f;
            Cursor.lockState = CursorLockMode.None;
            End.SetActive(true);
            Score.SetActive(false);
        }
        if (plat == 1)
        {
            info.text = "Score: " + score + "\nGoal is: 20";
        }
        else
        {
            info.text = "Score: " + score;
        }
    }
}

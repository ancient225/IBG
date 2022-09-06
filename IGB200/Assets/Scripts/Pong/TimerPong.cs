using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TimerPong : MonoBehaviour
{
    private TMPro.TextMeshProUGUI info;
    [HideInInspector] public float Timer;
    [SerializeField] private GameObject Score;

    // Start is called before the first frame update
    void Start()
    {
        info = gameObject.GetComponent<TMPro.TextMeshProUGUI>();
        Timer = 30;
    }

    // Update is called once per frame
    void Update()
    {
        Timer -= Time.deltaTime;

        info.text = "" + Mathf.RoundToInt(Timer) + "";

        if (Timer <= 0)
        {
            UniversalText.Points += Score.GetComponent<ScorePong>().score;
            SceneManager.LoadScene("IGB200");
        }
    }
}

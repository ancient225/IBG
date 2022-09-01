using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScorePong : MonoBehaviour
{
    private TMPro.TextMeshProUGUI info;
    [HideInInspector] public int score;

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

        info.text = "" + score + "";
    }
}

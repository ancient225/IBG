using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Text : MonoBehaviour
{
    private TMPro.TextMeshProUGUI info;
    [HideInInspector] public int UI;
    [HideInInspector] public int Points;
    private float t;
    private bool allow;

    // Start is called before the first frame update
    void Start()
    {
        allow = true;
        UI = UniversalText.story;
        info = gameObject.GetComponent<TMPro.TextMeshProUGUI>();
    }

    void UpdateStory()
    {
        if (!allow)
        {
            t += Time.deltaTime;
            if (t > 5)
            {
                t = 0;
                allow = true;
                UI = UniversalText.story;
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        Points = UniversalText.Points;

        UpdateStory();

        if (UI == 0)
        {
            info.text = "Go talk to Bob. Points: " + Points;
        }
        else if (UI == 1)
        {
            info.text = "Congrats. Points: " + Points;
        }

        if (UI == 99)
        {
            info.text = "Did you know 'interesting facts about certain field' how fasinating. Points: " + Points;

            if (allow)
            {
                t = 0;
                allow = false;
            }
        }
    }
}

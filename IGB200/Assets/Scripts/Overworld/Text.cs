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
            info.text = "Did you know 'interesting facts about certain field One Part one' how fasinating.";

            if (allow)
            {
                t = 0;
                allow = false;
            }
        }
        else if (UI == 98)
        {
            info.text = "Did you know 'interesting facts about certain field One part two' how fasinating.";

            if (allow)
            {
                t = 0;
                allow = false;
            }
        }
        else if (UI == 97)
        {
            info.text = "Did you know 'interesting facts about certain field Two Part one' how fasinating.";

            if (allow)
            {
                t = 0;
                allow = false;
            }
        }
        else if (UI == 96)
        {
            info.text = "Did you know 'interesting facts about certain field Two part two' how fasinating.";

            if (allow)
            {
                t = 0;
                allow = false;
            }
        }
        else if (UI == 95)
        {
            info.text = "Did you know 'interesting facts about certain field Three Part one' how fasinating.";

            if (allow)
            {
                t = 0;
                allow = false;
            }
        }
        else if (UI == 94)
        {
            info.text = "Did you know 'interesting facts about certain field Three part two' how fasinating.";
            if (allow)
            {
                t = 0;
                allow = false;
            }
        }
        else if (UI == 93)
        {
            info.text = "Did you know 'interesting facts about certain field Four' how fasinating.";

            if (allow)
            {
                t = 0;
                allow = false;
            }
        }
        else if (UI == 92)
        {
            info.text = "Mini Game three Coming soon!!!";

            if (allow)
            {
                t = 0;
                allow = false;
            }
        }
        else if (UI == 91)
        {
            info.text = "Mini Game four Coming soon!!!";

            if (allow)
            {
                t = 0;
                allow = false;
            }
        }
        else if (UI == 90)
        {
            info.text = "Shop coming soon!!!";

            if (allow)
            {
                t = 0;
                allow = false;
            }
        }
    }
}

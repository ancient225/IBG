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
            if (t > 3)
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
            info.text = "Story - Go talk to Bob. Points: " + Points;
        }
        else if (UI == 1)
        {
            info.text = "More story - Go talk to Pete. Points: " + Points;
        }
        else if (UI == 2)
        {
            info.text = "even more story - Go talk to Fred. Points: " + Points;
        }
        else if (UI == 3)
        {
            info.text = "and some more story - Go talk to Rebecca. Points: " + Points;
        }
        else if (UI == 4)
        {
            info.text = "story - Congrates go check out the shop. Points: " + Points + "  Thanks for playing the demo later we are planning for better level design more mini games and models";
        }



        if (UI == 99)
        {
            info.text = "Did you know there are two different types of white blood cells? The b lymphocyte blood cells create antibodies and warn the t lymphocyts of invading cells, who then destroy the antibody.";

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
        else if (UI == 86)
        {
            info.text = "Talk to Bob first";

            if (allow)
            {
                t = 0;
                allow = false;
            }
        }
        else if (UI == 87)
        {
            info.text = "Talk to Pete first";

            if (allow)
            {
                t = 0;
                allow = false;
            }
        }
        else if (UI == 88)
        {
            info.text = "Talk to Fred first";

            if (allow)
            {
                t = 0;
                allow = false;
            }
        }
         if (UI == 100 && allow)
        {
            info.text = "Press 'e'";
        }
    }
}

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
            info.text = "Here you are! Welcome to QUT open day! Feeling up to exploring QUT today? Let's meet my friend Bob, he is repersanting the sport club today.Try playing a game of ping pong with Bob. Points: " + Points;
        }
        else if (UI == 1)
        {
            info.text = "Yo that's pre good! Now is my friend Pete, he studies chemistry.let's help him out with his chemistry homework. Points: " + Points;
        }
        else if (UI == 2)
        {
            info.text = "Uni level chemistry has nothing on you! Maybe you could help out Fred with his robotics project? Points: " + Points;
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
            info.text = "Did you know QUT offers sports scholarships to people of all backgrounds, abilities and financial situations, how fasinating.";

            if (allow)
            {
                t = 0;
                allow = false;
            }
        }
        else if (UI == 97)
        {
            info.text = "Did you know QUT had a free online resource that teaches robotics from kindergarten to undergraduate level? It's called robot academy, how fasinating.";

            if (allow)
            {
                t = 0;
                allow = false;
            }
        }
        else if (UI == 96)
        {
            info.text = "Did you know that qut offers 23 seperate clubs for sports/recreation? how fasinating.";

            if (allow)
            {
                t = 0;
                allow = false;
            }
        }
        else if (UI == 95)
        {
            info.text = "In addition to biology, chemistry and physics, QUT also offers classes based on earth and environmental science' how fasinating.";

            if (allow)
            {
                t = 0;
                allow = false;
            }
        }
        else if (UI == 94)
        {
            info.text = "Did you know QUT offers 9 different arts degrees, involving acting, animation, creative writing, dance, drama, film screen and new media, music, technical production and visual arts, how fasinating.";
            if (allow)
            {
                t = 0;
                allow = false;
            }
        }
        else if (UI == 93)
        {
            info.text = "Did you know that C/C++ is the most common programming language used in robotics how fasinating.";

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
            info.text = "Throw ball in hoop";

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

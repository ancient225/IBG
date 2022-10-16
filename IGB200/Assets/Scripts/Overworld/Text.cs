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
<<<<<<< Updated upstream
<<<<<<< Updated upstream
            info.text = "Hey Player, feeling up to exploring QUT today? Try playing a game of ping pong with Bob. Points: " + Points;
        }
        else if (UI == 1)
        {
            info.text = "Yo that's pre good! Now let's help out Pete with his chemistry homework. Points: " + Points;
=======
            info.text = "Hello! Welcome to QUT open day! Wanna play a game of basketball with my friend Bob from the QUT basketball club?";
        }
        else if (UI == 1)
        {
            info.text = "Wow, you're practically NBA material! Maybe you could also help my friend Pete whith his chemistry project?";
>>>>>>> Stashed changes
=======
            info.text = "Hello! Welcome to QUT open day! Wanna play a game of basketball with my friend Bob from the QUT basketball club?";
        }
        else if (UI == 1)
        {
            info.text = "Wow, you're practically NBA material! Maybe you could also help my friend Pete whith his chemistry project?";
>>>>>>> Stashed changes
        }
        else if (UI == 2)
        {
            info.text = "Uni level chemistry has nothing on you! Maybe you could help out Fred with his robotics project?";
        }
        else if (UI == 3)
        {
            info.text = "Nice! My friend Rebecca needs help with her music project, maybe you could contribute a little?";
        }
        else if (UI == 4)
        {
<<<<<<< Updated upstream
<<<<<<< Updated upstream
            info.text = "story - Congrates go check out the shop. Points: " + Points + "  Thanks for playing the demo later we are planning for better level design more mini games and models";
=======
            info.text = "Thanks for playing the demo later we are planning for better level design more mini games and models";
>>>>>>> Stashed changes
=======
            info.text = "Thanks for playing the demo later we are planning for better level design more mini games and models";
>>>>>>> Stashed changes
        }



        if (UI == 99)
        {
            info.text = "Did you know that qut offers 23 seperate clubs for sports/recreation?";

            if (allow)
            {
                t = 0;
                allow = false;
            }
        }
        else if (UI == 98)
        {
<<<<<<< Updated upstream
<<<<<<< Updated upstream
            info.text = "Did you know 'interesting facts about certain field One part two' how fasinating.";
=======
            info.text = "Did you know QUT offers sports scholarships to people of all backgrounds, abilities and financial situations?";
>>>>>>> Stashed changes
=======
            info.text = "Did you know QUT offers sports scholarships to people of all backgrounds, abilities and financial situations?";
>>>>>>> Stashed changes

            if (allow)
            {
                t = 0;
                allow = false;
            }
        }
        else if (UI == 97)
        {
<<<<<<< Updated upstream
<<<<<<< Updated upstream
            info.text = "Did you know 'interesting facts about certain field Two Part one' how fasinating.";
=======
            info.text = "In addition to biology, chemistry and physics, QUT also offers classes based on earth and environmental science?";
>>>>>>> Stashed changes
=======
            info.text = "In addition to biology, chemistry and physics, QUT also offers classes based on earth and environmental science?";
>>>>>>> Stashed changes

            if (allow)
            {
                t = 0;
                allow = false;
            }
        }
        else if (UI == 96)
        {
<<<<<<< Updated upstream
<<<<<<< Updated upstream
            info.text = "Did you know 'interesting facts about certain field Two part two' how fasinating.";
=======
            info.text = "Did you know there are two different types of white blood cells? The b lymphocyte blood cells create antibodies and warn the t lymphocyts of invading cells, who then destroy the antibody.";
>>>>>>> Stashed changes
=======
            info.text = "Did you know there are two different types of white blood cells? The b lymphocyte blood cells create antibodies and warn the t lymphocyts of invading cells, who then destroy the antibody.";
>>>>>>> Stashed changes

            if (allow)
            {
                t = 0;
                allow = false;
            }
        }
        else if (UI == 95)
        {
<<<<<<< Updated upstream
<<<<<<< Updated upstream
            info.text = "Did you know 'interesting facts about certain field Three Part one' how fasinating.";
=======
            info.text = "Did you know QUT had a free online resource that teaches robotics from kindergarten to undergraduate level? It's called robot academy.";
>>>>>>> Stashed changes
=======
            info.text = "Did you know QUT had a free online resource that teaches robotics from kindergarten to undergraduate level? It's called robot academy.";
>>>>>>> Stashed changes

            if (allow)
            {
                t = 0;
                allow = false;
            }
        }
        else if (UI == 94)
        {
<<<<<<< Updated upstream
<<<<<<< Updated upstream
            info.text = "Did you know 'interesting facts about certain field Three part two' how fasinating.";
=======
            info.text = "Did you know QUT offers 9 different arts degrees, involving acting, animation, creative writing, dance, drama, film screen and new media, music, technical production and visual arts.";
>>>>>>> Stashed changes
=======
            info.text = "Did you know QUT offers 9 different arts degrees, involving acting, animation, creative writing, dance, drama, film screen and new media, music, technical production and visual arts.";
>>>>>>> Stashed changes
            if (allow)
            {
                t = 0;
                allow = false;
            }
        }
        else if (UI == 93)
        {
<<<<<<< Updated upstream
<<<<<<< Updated upstream
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
=======
            info.text = "Did you know QUT offers 9 different arts degrees, involving acting, animation, creative writing, dance, drama, film screen and new media, music, technical production and visual arts.";
>>>>>>> Stashed changes
=======
            info.text = "Did you know QUT offers 9 different arts degrees, involving acting, animation, creative writing, dance, drama, film screen and new media, music, technical production and visual arts.";
>>>>>>> Stashed changes

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

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class controlMainMenu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        UniversalText.story = 0;
        UniversalText.Points = 0;
    }

    // Update is called once per frame
    void Update()
    {
        SceneManager.LoadScene("IGB200");
    }
}

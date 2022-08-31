using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Text : MonoBehaviour
{
    private TMPro.TextMeshProUGUI info;
    [SerializeField] private GameObject Control;

    // Start is called before the first frame update
    void Start()
    {
        info = gameObject.GetComponent<TMPro.TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Control.GetComponent<control>().UI == 0)
        {
            info.text = "Go talk to Bob";
        }
        else if (Control.GetComponent<control>().UI == 1)
        {
            info.text = "Beat mini game";
        }
        else if (Control.GetComponent<control>().UI == 2)
        {
            info.text = "Congrats";
        }
    }
}

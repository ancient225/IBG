using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppleSpawnSnake : MonoBehaviour
{
    [SerializeField] private GameObject Apple;
    private int appleAmonut;

    // Start is called before the first frame update
    void Start()
    {
        appleAmonut = 3;
    }

    // Update is called once per frame
    void Update()
    {
        GameObject[] apples = GameObject.FindGameObjectsWithTag("apple");
        if(apples.Length < appleAmonut)
        {
            Instantiate(Apple, new Vector3(Mathf.RoundToInt(Random.Range(-7, 7)), Mathf.RoundToInt(Random.Range(-4, 5)), 0), new Quaternion(0, 0, 0, 0));
        }
    }
}

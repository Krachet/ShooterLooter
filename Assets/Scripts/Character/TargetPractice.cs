using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetPractice : MonoBehaviour
{
    public GameObject targetted;
    public bool isTargetted;

    // Update is called once per frame
    void Update()
    {
        if (isTargetted)
        {
            targetted.SetActive(true);
        }
        else
        {
            targetted.SetActive(false);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetingSystem : MonoBehaviour
{
    private PlayerAim playerAim;
    // Start is called before the first frame update
    void Start()
    {
        playerAim = FindObjectOfType<PlayerAim>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "TargetPractice")
        {
            Debug.Log("Hit");
            playerAim.SetTarget(other.gameObject);
            playerAim.targets.Add(other.gameObject);
            other.gameObject.GetComponent<TargetPractice>().isTargetted = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "TargetPractice")
        {
            playerAim.targets.Remove(other.gameObject);
            other.gameObject.GetComponent<TargetPractice>().isTargetted = false;
        }
    }
}

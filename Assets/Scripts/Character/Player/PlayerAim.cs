using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAim : Player
{
    private GameObject target;
    public List<GameObject> targets = new List<GameObject>();

    // Update is called once per frame
    void Update()
    {

    }

    public void SetTarget(GameObject target)
    {
        this.target = target;
    }
}

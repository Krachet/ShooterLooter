using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public Healthbar healthbarPf;
    public Healthbar healthbar;
    private void Start()
    {
        healthbar = Instantiate(healthbarPf, transform);
        healthbar.transform.SetParent(GameObject.Find("Canvas").transform, false);
        healthbar.OnInit(100, this.gameObject);
    }
}

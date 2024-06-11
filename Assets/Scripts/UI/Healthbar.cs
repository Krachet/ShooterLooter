using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Healthbar : MonoBehaviour
{
    //UI
    public Image healthbar;
    public TextMeshProUGUI healthText;

    //Stats 
    public float health;
    public float maxHealth;

    //Screen
    public GameObject target;
    [SerializeField] RectTransform rect;
    Vector3 viewpoint; 
    Vector3 halfScreen = new Vector2(Screen.width, Screen.height - 40) / 2;

    // Start is called before the first frame update
    public void OnInit(float maxHealth, GameObject target)
    {
        this.target = target;
        this.maxHealth = maxHealth;
        health = maxHealth;
        healthbar.fillAmount = 1;
    }

    // Update is called once per frame
    void Update()
    {
        viewpoint = Camera.main.WorldToScreenPoint(target.transform.position) - halfScreen;
        rect.anchoredPosition = viewpoint / (Screen.width / 1080f);
        healthText.text = health + "/" + maxHealth;
        healthbar.fillAmount = Mathf.Lerp(healthbar.fillAmount, health / maxHealth, Time.deltaTime * 5f);
    }

    public void SetHP(float hp)
    {
        health = hp;
    }

    public float GetHP()
    {
        return health;
    }
}

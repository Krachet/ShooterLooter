using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemMove : MonoBehaviour
{
    public GameObject player;
    public float speed;

    private bool inPickupRange;

    public float damage;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        speed = 6f;
        inPickupRange = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (inPickupRange)
        {
            transform.position = Vector3.MoveTowards(transform.position, player.transform.position + Vector3.up, speed * Time.deltaTime);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "ItemPickupRange")
        {
            inPickupRange = true;
        }

        if (other.gameObject.tag == "Player")
        {
            other.gameObject.GetComponent<PlayerHealth>().healthbar.SetHP(other.gameObject.GetComponent<PlayerHealth>().healthbar.GetHP() - damage);
            Destroy(gameObject);
        }
    }
}

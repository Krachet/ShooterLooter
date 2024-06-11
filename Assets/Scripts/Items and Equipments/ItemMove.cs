using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemMove : MonoBehaviour
{
    public GameObject player;
    public float speed;

    private bool inPickupRange;

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
            MoveTo(transform.position, player.transform.position);
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
            Destroy(gameObject);
        }
    }

    public void MoveTo(Vector3 startPos, Vector3 target)
    {
        transform.position = Vector3.MoveTowards(startPos, target + Vector3.up, speed * Time.deltaTime);   
    }
}

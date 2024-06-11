using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : Player
{
    public float speed = 5f;
    public LayerMask ground;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0) && JoystickControl.direct != Vector3.zero)
        {
            Vector3 nextpos = transform.position + JoystickControl.direct * speed * Time.deltaTime;
            if (CanMove(nextpos))
            {
                ChangeState(AnimationState.Run);
                transform.position += JoystickControl.direct * speed * Time.deltaTime;
                transform.forward = JoystickControl.direct;
            }
        }
        else if (Input.GetMouseButtonUp(0))
        {
            ChangeState(AnimationState.Idle);
        }
    }

    public bool CanMove(Vector3 nextpos)
    {
        if (Physics.Raycast(nextpos + Vector3.up, Vector3.down, Mathf.Infinity, ground))
        {
            return true;
        }
        else
        {  
            return false;
        }
    }
}

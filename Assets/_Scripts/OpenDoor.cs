using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDoor : MonoBehaviour
{

    public float IsOpen = 0f;
    public float Cooldown = 0f;
    public Transform doorTransform;
    public float doorRotation;

    private void Update()
    {

        Cooldown = Cooldown - Time.deltaTime;

    }

    //Destroys the door when the player interacts with is by pressing e
    private void OnTriggerStay2D(Collider2D collision)
    {

        if (Input.GetKey("e") && collision.gameObject.tag == "Player")
        {

            if (IsOpen == 0f && Cooldown <= 0f)
            {

                float rotateDoorTo = doorTransform.rotation.eulerAngles.z - 90f;

                transform.rotation = Quaternion.Euler(0, 0, rotateDoorTo);
                IsOpen = 1f;
                Cooldown = 0.2f;

            }

            if (IsOpen == 1f && Cooldown <= 0f)
            {

                float rotateDoorTo = doorTransform.rotation.eulerAngles.z + 90f;

                transform.rotation = Quaternion.Euler(0, 0, rotateDoorTo);
                IsOpen = 0f;
                Cooldown = 0.2f;

            }

        }

    }

}

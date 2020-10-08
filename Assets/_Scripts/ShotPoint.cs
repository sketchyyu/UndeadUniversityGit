using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShotPoint : MonoBehaviour
{

    public Transform PT;

    // Update is called once per frame
    void Update()
    {

        //Sets the position for one of the transforms used to cast a line by the Shooting script
        transform.position = new Vector3(PT.position.x, PT.position.y, 0f);

    }
}

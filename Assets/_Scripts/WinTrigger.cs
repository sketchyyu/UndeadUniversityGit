using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinTrigger : MonoBehaviour
{

    public YouWIn youWin;

    private void OnTriggerEnter2D()
    {

        youWin.Win();

    }
}

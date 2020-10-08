using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class YouWIn : MonoBehaviour
{

    public Text Text;

    // Start is called before the first frame update
    void Start()
    {

        //Gets the text component
        Text = GetComponent<Text>();

    }

    // Update is called once per frame
    public void Win()
    {

        Text.text = ("YOU WIN");

    }
}

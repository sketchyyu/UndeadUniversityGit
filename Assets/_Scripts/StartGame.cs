using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour
{

    public void Begin()
    {

        Debug.Log("start");
        SceneManager.LoadScene("Floor 3", LoadSceneMode.Single);

    }

}

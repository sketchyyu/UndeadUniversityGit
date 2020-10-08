using UnityEngine;
using UnityEngine.SceneManagement;

public class QuitGame : MonoBehaviour
{

    //Quits the game when the quit game button is pressed
    public void Quit()
    {

        Application.Quit();

    }

    public void Respawn()
    {

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

    }
}

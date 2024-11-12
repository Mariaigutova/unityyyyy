using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadScene("Characters"); // Замените на название сцены выбора персонажа 
    }
    /*
    public void ContinueGame()
    {
        // Здесь добавьте код для продолжения игры
    }
    */

    public void ExitGame()
    {
        Application.Quit();
    }
}

using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadScene("Characters"); // �������� �� �������� ����� ������ ��������� 
    }
    /*
    public void ContinueGame()
    {
        // ����� �������� ��� ��� ����������� ����
    }
    */

    public void ExitGame()
    {
        Application.Quit();
    }
}

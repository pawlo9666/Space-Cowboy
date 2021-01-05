
using UnityEngine;
using UnityEngine.SceneManagement;


public class MenuButtons : MonoBehaviour
{
    public GameObject MenuPanel;
    public GameObject OptionsPanel;
    // Start is called before the first frame update
    void Start()
    {
        MenuPanel.SetActive(true);
        OptionsPanel.SetActive(false);
    }

    public void StartGame()
    {
        SceneManager.LoadScene("FirstLevel");
    }
    public void ShowOptions()
    {
        MenuPanel.SetActive(false);
        OptionsPanel.SetActive(true);
    }

    public void ShowMenuPanel()
    {
        MenuPanel.SetActive(true);
        OptionsPanel.SetActive(false);
    }

    public void ExitButton()
    {
        Application.Quit();
    }

}

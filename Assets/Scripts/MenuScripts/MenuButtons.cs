
using UnityEngine;
using UnityEngine.SceneManagement;


public class MenuButtons : MonoBehaviour
{
    public GameObject MenuPanel;
    public GameObject OptionsPanel;
    public GameObject RulesPanel;
    // Start is called before the first frame update
    void Start()
    {
        MenuPanel.SetActive(true);
        OptionsPanel.SetActive(false);
        RulesPanel.SetActive(false);
    }

    public void StartGame()
    {
        SceneManager.LoadScene("FirstLevel");
    }
    public void ShowOptions()
    {
        MenuPanel.SetActive(false);
        OptionsPanel.SetActive(true);
        RulesPanel.SetActive(false);
    }

    public void ShowMenuPanel()
    {
        MenuPanel.SetActive(true);
        OptionsPanel.SetActive(false);
        RulesPanel.SetActive(false);
    }

    public void ShowRules()
    {
        MenuPanel.SetActive(false);
        OptionsPanel.SetActive(false);
        RulesPanel.SetActive(true);
    }

    public void ExitButton()
    {
        Application.Quit();
    }

}

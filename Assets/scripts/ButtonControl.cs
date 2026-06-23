using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ButtonBehavior : MonoBehaviour
{

    public GameObject theText;
    public AudioSource clearSound;
    public GameObject thePanel;

    void Start()
    {
        thePanel.SetActive(false);
    }
    public void ClearText()
    {
        theText.GetComponent<TMP_InputField>().text="";
        clearSound.Play();
    }

    public void CancelButton()
    {
        thePanel.SetActive(false);
    }

    public void CloseButton()
    {
        thePanel.SetActive(true);
    }

    public void QuitButton()
    {
        Application.Quit();
    }

}

using System.Collections;
using TMPro;
using UnityEngine;
// using UnityEngine.UI;

public class SaveLoad : MonoBehaviour
{
    public TMP_InputField inputField;
    public GameObject saveAnim;

    void Start()
    {
        inputField.text = PlayerPrefs.GetString("NoteContents", "");
    }

    public void SaveNote()
    {
        PlayerPrefs.SetString("NoteContents", inputField.text);
        PlayerPrefs.Save();
        StartCoroutine(saveTextRoll());
    }

    IEnumerator saveTextRoll()
    {
        saveAnim.GetComponent<Animator>().Play("SaveAnimation");
        yield return new WaitForSeconds(1);
        saveAnim.GetComponent<Animator>().Play("New State");
    }

    /*
    public string theText;
    public GameObject ourNote;
    public GameObject placeHolder;
    void Start()
    {
        theText = PlayerPrefs.GetString("NoteContents");
        Debug.Log("Loaded: " + theText);
        
        placeHolder.GetComponent<TMP_InputField>().text = theText;
    }

    public void SaveNote()
    {
        theText = ourNote.GetComponent<Text>().text;
        Debug.Log("Saving: " + theText);

        PlayerPrefs.SetString("NoteContents",theText);
        PlayerPrefs.Save();
    }
    */
}

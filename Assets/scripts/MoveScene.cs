using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MoveScene : MonoBehaviour
{
    void Start()
    {
        StartCoroutine(MoveToNext());
    }

    IEnumerator MoveToNext()
    {
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene(1);
    }
}

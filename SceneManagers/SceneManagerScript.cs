using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneManagerScript : MonoBehaviour
{
    public Text ValueTxt;

    private void Start()
    {
        ValueTxt.text = PersistentManagerScript.Instance.Value.ToString();
    }

    public void GoToFirstScene()
    {
        SceneManager.LoadScene("first");
        PersistentManagerScript.Instance.Value++;
    }

    public void GoToSecondScene()
    {
        SceneManager.LoadScene("second");
        PersistentManagerScript.Instance.Value++;
    }
}

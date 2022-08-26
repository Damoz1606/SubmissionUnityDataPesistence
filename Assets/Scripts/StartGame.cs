using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour
{
    [SerializeField] private TMP_InputField usernameInput;

    private ScenePersistentData data;

    private void Start()
    {
        this.data = GameObject.Find("ScenePersistentData").GetComponent<ScenePersistentData>();

        if (this.data.Username != string.Empty || this.data.Username != null)
        {
            this.usernameInput.text = data.Username;
        }
    }

    public void StartGameEvent()
    {
        if (this.usernameInput.text != string.Empty || this.usernameInput.text != null)
        {
            this.data.Username = this.usernameInput.text;
            SceneManager.LoadScene(1, LoadSceneMode.Single);
        }
    }
}

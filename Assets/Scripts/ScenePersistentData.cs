using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScenePersistentData : MonoBehaviour
{
    private string username;

    public string Username { set { username = value; } get { return this.username; } }

    void Start()
    {
        DontDestroyOnLoad(this);
    }


}

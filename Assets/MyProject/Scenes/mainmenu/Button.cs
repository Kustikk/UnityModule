using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class button : MonoBehaviour
{

    public void BtnPlay_Click()
    {
        SceneManager.LoadScene("Gameplay");
    }
}

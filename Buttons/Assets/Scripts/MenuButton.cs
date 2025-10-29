using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuButton : MonoBehaviour
{
    // Start is called before the first frame update

    public void IfButton()
    {
        SceneManager.LoadScene("Scene2");
    }

    // Update is called once per frame

}

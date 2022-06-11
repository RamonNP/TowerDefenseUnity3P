using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UnlockLevel : MonoBehaviour
{

    public Button[] botões;
    

    // Start is called before the first frame update
    void Start()
    {
        PlayerPrefs.SetInt("faseComplet", 0);
    }

    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < botões.Length; i++)
        {
            if (i + 2 > PlayerPrefs.GetInt("faseCompleta"))
            {
                botões[i].interactable = false;
            }
            
        }
    }
}

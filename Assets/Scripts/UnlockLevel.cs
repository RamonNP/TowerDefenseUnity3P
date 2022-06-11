using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UnlockLevel : MonoBehaviour
{

    public Button[] bot�es;
    

    // Start is called before the first frame update
    void Start()
    {
        PlayerPrefs.SetInt("faseComplet", 0);
    }

    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < bot�es.Length; i++)
        {
            if (i + 2 > PlayerPrefs.GetInt("faseCompleta"))
            {
                bot�es[i].interactable = false;
            }
            
        }
    }
}

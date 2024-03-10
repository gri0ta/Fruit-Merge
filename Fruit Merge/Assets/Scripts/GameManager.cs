using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour

{
    public GameObject playText;
    public GameObject mergeFruitText;

    public void Start()
    {
        TextDisappear();
    }

    public void TextDisappear()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            playText.SetActive(false);
            mergeFruitText.SetActive(false);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class StringScript : MonoBehaviour
{
    private string name;
    public TextMeshProUGUI text;
    public TMP_InputField input;

    void Update()
    {
        name = input.text;
        text.text = "You're Name is " + name;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class BoolScript : MonoBehaviour
{
    public bool theBool;
    public TextMeshProUGUI text;
    public Toggle toggle;

    private void Update()
    {
        theBool = toggle.isOn;
        text.text = "Bool: " + theBool;
    }
}

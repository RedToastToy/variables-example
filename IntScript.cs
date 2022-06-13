using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class IntScript : MonoBehaviour
{
    private int age;
    public TextMeshProUGUI ageText;
    public TMP_Dropdown ageDropdown;

    void Update()
    {
        age = ageDropdown.value;
        ageText.text = "Age: " + age.ToString();
    }
}

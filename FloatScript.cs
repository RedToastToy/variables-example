using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class FloatScript : MonoBehaviour
{
    private Rigidbody rb;
    private float Mass;
    private float Drag;
    private float angularDrag;
    public TextMeshProUGUI masstext;
    public Slider massslider;
    public TextMeshProUGUI dragtext;
    public Slider dragslider;
    public TextMeshProUGUI angulardragtext;
    public Slider angulardragslider;

    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>();
    }

    void Update()
    {
        Mass = massslider.value;
        masstext.text = "Mass: " + Mass.ToString();
        rb.mass = Mass;
        Drag = dragslider.value;
        dragtext.text = "Drag: " + Drag.ToString();
        rb.drag = Drag;
        angularDrag = angulardragslider.value;
        angulardragtext.text = "Angular Drag: " + angularDrag.ToString();
        rb.angularDrag = angularDrag;
    }
}

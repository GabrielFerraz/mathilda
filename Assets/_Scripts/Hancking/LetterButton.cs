using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class LetterButton : MonoBehaviour
{

    private Image _image;

    private Color[] _colors = new[]
    {
        Color.red,
        Color.green,
        Color.blue,
        Color.yellow,
        Color.magenta,
        Color.cyan
    };

    private string letter;
    private int color;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _image = GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetValues(string v)
    {
        var values = v.Split('|');
        var image = GetComponent<Image>();
        image.color = _colors[Int64.Parse(values[1])];
        var text = GetComponentInChildren<TMP_Text>();
        text.text = values[0];
    }
}

enum COLORS
{
    Red,
    Green,
    Blue,
    Yellow,
    Magenta,
    Cyan
}
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class DebugConsole : MonoBehaviour
{
    [SerializeField]
    public GameObject _textFrame;
    [SerializeField]
    public int _maxLength = 5000;
    [SerializeField]
    public Text _text;

    private void Awake()
    {
        AddText("Debug is running.");
        
    }
    public void AddText(string text1)
    {
        _text.text = text1 + Environment.NewLine + _text.text;
        if (_text.text.Length > _maxLength)
        {
            _text.text = _text.text.Substring(0, _maxLength / 2);
        }
    }
    public void OnClick_Button()
    {
        _textFrame.SetActive(!_textFrame.activeSelf);
    }
}

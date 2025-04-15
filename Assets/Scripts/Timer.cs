using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{

    [SerializeField] private TextMeshProUGUI _textTemps;
    private float _tempMax = 10;
    [SerializeField] private float _tempsEcoule;
    [SerializeField] private Image _image;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Decompte();
    }

    void Decompte(){

        _tempsEcoule += Time.deltaTime*10;

        int _minutes = Mathf.FloorToInt(_tempsEcoule / 60);
        _textTemps.text = _minutes.ToString();

        int _secondes = Mathf.FloorToInt(_tempsEcoule % 60);
        //_textTemps.text = _minutes.ToString() + " : " + _secondes.ToString();

        _textTemps.text = string.Format("{0:00}",_secondes);

        _image.fillAmount += 0.025f;

    }

}

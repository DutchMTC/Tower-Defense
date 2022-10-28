using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using TMPro;
using UnityEngine;

public class CurrentWave : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI _waveText;
    private int _currentWave;

    // Update is called once per frame
    void Update()
    {
        _currentWave = GameObject.Find("LevelManager").GetComponent<LevelManager>().CurrentWave;
        _waveText.text = "Wave " + _currentWave.ToString();
    }
}

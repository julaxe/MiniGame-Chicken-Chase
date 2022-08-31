using System.Collections;
using System.Collections.Generic;
using _Scripts.Managers;
using _Scripts.Systems;
using UnityEngine;
using TMPro;

public class ScoreUI : MonoBehaviour
{
    private TextMeshProUGUI tmpPro;
    void Start()
    {
        tmpPro = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        if(tmpPro)
        {
            tmpPro.text = ScoreManager.Instance.GetScore().ToString();
        }
    }
}

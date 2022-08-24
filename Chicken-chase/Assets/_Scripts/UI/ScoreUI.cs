using System.Collections;
using System.Collections.Generic;
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
            tmpPro.text = ScoreSystem.Instance.GetScore().ToString();
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreUI : MonoBehaviour
{
    private TextMeshPro tmpPro;
    void Start()
    {
        tmpPro = GetComponent<TextMeshPro>();
    }

    // Update is called once per frame
    void Update()
    {
        tmpPro.text = ScoreSystem.GameScore.ToString();
    }
}

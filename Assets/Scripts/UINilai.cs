using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UINilai : MonoBehaviour
{
    public static UINilai instance;

    public TextMeshProUGUI ScoreText;
    int m_Points;

    private void Awake()
    {
        instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        ScoreText.text = "Nilai :" + m_Points;
    }

    public void AddPoint(int point)
    {
        m_Points += point;
        ScoreText.text = "Nilai :" + m_Points;
    }

}

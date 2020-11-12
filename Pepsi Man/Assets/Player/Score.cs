using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Text text;
    public float points = 0;

    public void OnGUI()
    {
        text.text = points.ToString();
    }

}

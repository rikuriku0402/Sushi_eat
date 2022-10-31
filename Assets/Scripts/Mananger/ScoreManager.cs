using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : SingletonMonoBehaviour<ScoreManager>
{
    public int Score => _score;

    int _score;

    private void Start()
    {
        _score = 0;
    }

    public int ScoreUp(int score) => _score += score;
}

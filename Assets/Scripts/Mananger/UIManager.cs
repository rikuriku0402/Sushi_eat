using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : SingletonMonoBehaviour<UIManager>
{
    public Text ScoreText => _scoreText;

    public Slider HPSlider => _hpSlider;

    float _hpValue;

    [SerializeField]
    [Header("�X�R�A�e�L�X�g")]
    Text _scoreText;

    [SerializeField]
    [Header("HP�X���C�_�[")]
    Slider _hpSlider;

    private void Start()
    {
        _hpValue = 100f;
    }

    void Update()
    {
        if (_hpValue <= 500)
        {
            _hpValue -= 0.05f;
        }
        if (_hpSlider.value == 0)
        {
            print("GameOver");
        }
        _hpSlider.value = _hpValue * 1f;
    }

    public void HPUp(float HP)
    {
        print(HP);
        _hpValue += HP;
    }
}

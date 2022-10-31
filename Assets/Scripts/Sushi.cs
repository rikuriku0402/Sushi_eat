using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using StarterAssets;

public class Sushi : MonoBehaviour
{
    const string PLAYER_TAG = "Player";

    [SerializeField]
    [Header("ÉXÉRÉA")]
    int _score;

    [SerializeField]
    [Header("StarterAseet")]
    ThirdPersonController _controller;

    private void Start()
    {
        _controller = GetComponent<ThirdPersonController>();
    }

    private void Update()
    {
        if (transform.position.y == -10)
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == PLAYER_TAG)
        {
            ScoreManager.Instance.ScoreUp(_score);
            UIManager.Instance.ScoreText.text = ScoreManager.Instance.Score.ToString();
            UIManager.Instance.HPUp(20);
            Destroy(gameObject);
        }
    }

    IEnumerator SpeedUp(float time)
    {
        _controller.MoveSpeed *= 0.2f;
        _controller.SprintSpeed *= 0.2f;

        yield return new WaitForSeconds(time);

        _controller.MoveSpeed = 2;
        _controller.SprintSpeed = 5.335f;
    }
}
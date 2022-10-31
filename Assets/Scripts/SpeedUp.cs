using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using StarterAssets;

public class SpeedUp : MonoBehaviour
{
    [SerializeField]
    [Header("StarterAssets")]
    ThirdPersonController _controller;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Sushi")
        {
            StartCoroutine(SpeedUP(1f));
        }
    }
    IEnumerator SpeedUP(float time)
    {
        _controller.MoveSpeed = 4.0f;
        _controller.SprintSpeed = 8.0f;

        yield return new WaitForSeconds(time);

        _controller.MoveSpeed = 2;
        _controller.SprintSpeed = 5.335f;
    }
}

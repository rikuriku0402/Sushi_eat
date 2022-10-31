using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSushi : MonoBehaviour
{
    [SerializeField]
    [Header("ŽõŽiƒŠƒXƒg")]
    List<GameObject> _sushi = new();

    void Update()
    {
        if (Time.frameCount % 500 == 0)
        {
            float x = Random.Range(50f, 90f);
            float z = Random.Range(22f, 60f);
            Vector3 pos = new Vector3(x, 40f, z);

            for (int i = 0; i < _sushi.Count; i++)
            {
                Instantiate(_sushi[i], pos, Quaternion.identity);
            }
        }
    }
}

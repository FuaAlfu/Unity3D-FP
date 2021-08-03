using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 2021.8.3
/// </summary>

namespace Platforms
{
    public class RoutatePlatform : MonoBehaviour
    {
        [SerializeField]
        private float _speed;
        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            transform.Rotate(Vector3.forward * _speed * Time.deltaTime);
        }
    }
}

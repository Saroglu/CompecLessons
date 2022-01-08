using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Lessons
{
    public class RotateObject : MonoBehaviour
    {
        [SerializeField] private float _speed=20f;

        private void Update()
        {
            // y ekseni hareket ettirir hız kadar
            transform.Rotate(Vector3.up, _speed*Time.deltaTime);
        }
    }
}


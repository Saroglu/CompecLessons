using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Lessons
{
    public class RotateObject : MonoBehaviour
    {
        [SerializeField] private RotateSettings _rotateSettings;

        private void Update()
        {
            // y ekseni hareket ettirir hız kadar
            transform.Rotate(Vector3.up, _rotateSettings.Speed * Time.deltaTime);
        }
    }
}


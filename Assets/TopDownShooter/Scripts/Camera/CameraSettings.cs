using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TopDownShooter
{
    [CreateAssetMenu(menuName ="TopDown Shooter/Camera/Camerea Settings")]
    public class CameraSettings : ScriptableObject
    {
        [Header("Rotation")]
        [SerializeField] private float _rotationLerpSpeed;
        public float RotationLerpSpeed { get { return _rotationLerpSpeed; } }


        [Header("Position")]
        [SerializeField] private Vector3 _positionOffset;
        public Vector3 PositionOffset { get { return _positionOffset; } }

        [SerializeField] private float _positionLerp=1;
        public float PositionLerp { get { return _positionLerp; } }
    }
}
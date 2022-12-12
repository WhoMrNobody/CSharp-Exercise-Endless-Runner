using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UdemyCourse2.Controller
{
    public class FloorController : MonoBehaviour
    {
        [Range(0.5f, 2f)]
        [SerializeField] float _floorMoveSpeed ;
        Material _groundMaterial;

        void Awake()
        {
            _groundMaterial = GetComponentInChildren<MeshRenderer>().material;
        }

        void Update()
        {
            _groundMaterial.mainTextureOffset += Vector2.down * Time.deltaTime * _floorMoveSpeed;
        }
    }

}

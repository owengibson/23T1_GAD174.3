using KartGame.KartSystems;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Needle : MonoBehaviour
{
    [SerializeField] private ArcadeKart character;

    [Range(1f, 300f)]
    [SerializeField] private float rotationMultiplier = 281f;
    private float rot;

    private void FixedUpdate()
    {

        rot = Mathf.Abs(character.LocalSpeed() * rotationMultiplier);
        transform.rotation = Quaternion.Euler(transform.rotation.x, transform.rotation.y, transform.rotation.z - rot);
    }
}

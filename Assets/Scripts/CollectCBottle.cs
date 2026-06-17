using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectCBottle : MonoBehaviour
{
    [SerializeField] AudioSource cbottleFX;

    void OnTriggerEnter(Collider other)
    {
        cbottleFX.Play();
        this.gameObject.SetActive(false);
    }
}
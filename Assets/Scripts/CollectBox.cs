using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class CollectCBox : MonoBehaviour
{
    [SerializeField] AudioSource boxFX;

    void OnTriggerEnter(Collider other)
    {
        boxFX.Play();
        MasterInfo.boxCount += 1;
        this.gameObject.SetActive(false);
    }
}   
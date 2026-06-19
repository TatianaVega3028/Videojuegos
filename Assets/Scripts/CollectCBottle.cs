using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class CollectCBottle : MonoBehaviour
{
    [SerializeField] AudioSource cbottleFX;

    void OnTriggerEnter(Collider other)
    {
        cbottleFX.Play();
        MasterInfo.cbottleCount += 1;
        this.gameObject.SetActive(false);
    }
}   
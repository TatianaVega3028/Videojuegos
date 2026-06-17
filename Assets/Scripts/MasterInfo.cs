using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MasterInfo : MonoBehaviour
{
    public static int cbottleCount = 0;
    [SerializeField] GameObject cbottleDisplay;
    void Update()
    {
        cbottleDisplay.GetComponent<TMPro.TMP_Text>().text = " BOTELLAS:" + cbottleCount;
    }
}

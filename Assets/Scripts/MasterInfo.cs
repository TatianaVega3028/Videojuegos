using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MasterInfo : MonoBehaviour
{
    public static int cbottleCount = 0;
    [SerializeField] GameObject cbottleDisplay;
    public static int boxCount = 0;
    public static int distanceRun;
    [SerializeField] int internalDistance;
    [SerializeField] GameObject boxDisplay;
    [SerializeField] GameObject runDisplay;
    void Update()
    {
        internalDistance = distanceRun;
        cbottleDisplay.GetComponent<TMPro.TMP_Text>().text = "" + cbottleCount;
        boxDisplay.GetComponent<TMPro.TMP_Text>().text = "" + boxCount;
        runDisplay.GetComponent<TMPro.TMP_Text>().text = "" + distanceRun;
    }
}

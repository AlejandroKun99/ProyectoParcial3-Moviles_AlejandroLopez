using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenTransition : MonoBehaviour
{
    public GameObject ThisScreen;
    public GameObject NextScreen;

    public void Transition()
    {
        ThisScreen.SetActive(false);
        NextScreen.SetActive(true);
    }
}

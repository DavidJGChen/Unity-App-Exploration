using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Dawid {
public class AppManager : MonoBehaviour
{
    private void Awake() {
        Screen.SetResolution(1600, 900, false, 30);

        Application.targetFrameRate = 30;
    }
}
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Leap.Unity
{
    public class StartUp : MonoBehaviour
    {
        DetectorLogicGate Index;
        Coroutine co;
        public KeyStroke start;

        IEnumerator Timer()
        {
            yield return new WaitForSeconds(2.0f);
            start.LCTRL_KeyDown();
            yield return new WaitForSeconds(0.1f);
            start.RCTRL_KeyDown();
            yield return new WaitForSeconds(0.1f);
            start.HOME_KeyDown();
            yield return new WaitForSeconds(0.1f);
            start.HOME_KeyUp();
            yield return new WaitForSeconds(0.1f);
            start.RCTRL_KeyUp();
            yield return new WaitForSeconds(0.1f);
            start.LCTRL_KeyUp();
            //co = StartCoroutine(Timer());
            StopAllCoroutines(); // ******
        }

        public void EngineStartUp()
        {
            co = StartCoroutine(Timer());
        }

        public void CancelStartUp()
        {
            start.RCTRL_KeyUp();   // avoid parasite comportement if RCTRL is seen as down after executing Timer()
            start.LCTRL_KeyUp();  // avoid parasite comportement if LCTRL is seen as down after executing Timer()
            StopAllCoroutines();
        }
    }
}

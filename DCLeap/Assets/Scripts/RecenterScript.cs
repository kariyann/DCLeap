using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Leap.Unity
{ 
    public class RecenterScript : MonoBehaviour
    {
        public KeyStroke recenter;
        Coroutine co;

        IEnumerator Timer()
        {
            recenter.LSHIFT_KeyDown();
            yield return new WaitForSeconds(0.1f);
            recenter.RCTRL_KeyDown();
            yield return new WaitForSeconds(0.1f);
            recenter.HOME_KeyDown();
            yield return new WaitForSeconds(0.1f);
            recenter.HOME_KeyUp();
            yield return new WaitForSeconds(0.1f);
            recenter.RCTRL_KeyUp();
            yield return new WaitForSeconds(0.1f);
            recenter.LSHIFT_KeyUp();
            yield return new WaitForSeconds(0.1f);
            //co = StartCoroutine(Timer());
            StopAllCoroutines(); // **********
        }

        public void Recenter()
        {
            co = StartCoroutine(Timer());
        }

        public void EndRecenter()
        {
            recenter.RCTRL_KeyUp();  // avoid parasite comportement if RCTRL is seen as down after executing Timer()
            recenter.LSHIFT_KeyUp();  // avoid parasite comportement if LSHIFT is seen as down after executing Timer()
            StopAllCoroutines();
        }
    }
}

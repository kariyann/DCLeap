using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using WindowsInput;
using WindowsInput.Native;

public class Ejection : MonoBehaviour
{
    InputSimulator sim;
    Coroutine co;


    // Start is called before the first frame update
    void Start()
    {
        sim = new InputSimulator(); 
    }

    // LCTRL
    public void LCTRL_KeyDown()
    {
        sim.Keyboard.KeyDown(VirtualKeyCode.LCONTROL);
    }

    IEnumerator E1()
    {
        yield return new WaitForSeconds(0.1f);
        sim.Keyboard.KeyDown(VirtualKeyCode.VK_E);
    }

    IEnumerator E2()
    {
        yield return new WaitForSeconds(0.2f);
        sim.Keyboard.KeyUp(VirtualKeyCode.VK_E);
    }

    IEnumerator E3()
    {
        yield return new WaitForSeconds(0.3f);
        sim.Keyboard.KeyDown(VirtualKeyCode.VK_E);
    }

    IEnumerator E4()
    {
        yield return new WaitForSeconds(0.4f);
        sim.Keyboard.KeyUp(VirtualKeyCode.VK_E);
    }

    IEnumerator E5()
    {
        yield return new WaitForSeconds(0.6f);
        sim.Keyboard.KeyDown(VirtualKeyCode.VK_E);
    }

    IEnumerator E6()
    {
        yield return new WaitForSeconds(0.8f);
        sim.Keyboard.KeyUp(VirtualKeyCode.VK_E);
    }

    IEnumerator LCTRL_KeyUp()
    {
        yield return new WaitForSeconds(1.0f);
        sim.Keyboard.KeyUp(VirtualKeyCode.LCONTROL);
    }

    IEnumerator CoroutineDestructor()
    {
        yield return new WaitForSeconds(1.1f);
        StopAllCoroutines();
    }

    public void Eject()
    {
        LCTRL_KeyDown();
        StartCoroutine(E1());
        StartCoroutine(E2());
        StartCoroutine(E3());
        StartCoroutine(E4());
        StartCoroutine(E5());
        StartCoroutine(E6());
        StartCoroutine(LCTRL_KeyUp());
        StartCoroutine(CoroutineDestructor());
    }
}

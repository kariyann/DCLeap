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
        yield return new WaitForSeconds(0.05f);
        sim.Keyboard.KeyDown(VirtualKeyCode.VK_E);
    }

    IEnumerator E2()
    {
        yield return new WaitForSeconds(0.10f);
        sim.Keyboard.KeyUp(VirtualKeyCode.VK_E);
    }

    IEnumerator E3()
    {
        yield return new WaitForSeconds(0.15f);
        sim.Keyboard.KeyDown(VirtualKeyCode.VK_E);
    }

    IEnumerator E4()
    {
        yield return new WaitForSeconds(0.20f);
        sim.Keyboard.KeyUp(VirtualKeyCode.VK_E);
    }

    IEnumerator E5()
    {
        yield return new WaitForSeconds(0.25f);
        sim.Keyboard.KeyDown(VirtualKeyCode.VK_E);
    }

    IEnumerator E6()
    {
        yield return new WaitForSeconds(0.30f);
        sim.Keyboard.KeyUp(VirtualKeyCode.VK_E);
    }

    IEnumerator LCTRL_KeyUp()
    {
        yield return new WaitForSeconds(0.35f);
        sim.Keyboard.KeyUp(VirtualKeyCode.LCONTROL);
    }

    IEnumerator CoroutineDestructor()
    {
        yield return new WaitForSeconds(0.40f);
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

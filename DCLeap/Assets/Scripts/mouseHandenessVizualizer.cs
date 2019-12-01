using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mouseHandenessVizualizer : MonoBehaviour
{
    public bool MouseVizualizer = true;
    public GameObject CubeSelector;

    // Start is called before the first frame update
    void Start()
    {
        CubeSelector.SetActive(MouseVizualizer) ;
    }

    // Update is called once per frame
    void Update()
    {
        CubeSelector.SetActive(MouseVizualizer);
    }
}

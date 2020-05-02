using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


namespace Leap.Unity
{
    public class EjectionVizualizer : MonoBehaviour
    {
        public GameObject EjectionHandler;
        public GameObject SubObjectHandler;
        public GameObject LeftHand;
        public GameObject RightHand;
        public MeshRenderer MeshHandler;
        public Canvas PullToEJect;
        public Material YellowMaterial;
        public Material RedMaterial;
        public TextMeshProUGUI ShownText;
        //public KeyStroke eject; //pour test
        public Ejection eject;
        Vector3 originalPosition;
        Coroutine co;

        void Start()
        {
            int ejectionValue = PlayerPrefs.GetInt("Ejection");        //verify that user wants to use ejection module
            if (ejectionValue == 0)
            {
                EjectionHandler.SetActive(false);
            }
            originalPosition = new Vector3(SubObjectHandler.transform.position.x, SubObjectHandler.transform.position.y, SubObjectHandler.transform.position.z); //get start position of ejection handle bar
        }

        //IEnumerator 
            void CountDown()
        {
            ShownText.text = "Ejection imminent";
           // yield return new WaitForSeconds(0.6f);  // (1.0f);                 //wait 1 seconds when bar is grabbed before commanding the ejection, this let user reverse ejection decision during 1 second
           // ShownText.text = "Ejection !!!";
            eject.Eject();
           // eject.EjectionCommand();  //pour test
            //co = StartCoroutine(CountDown());
        }

        public void ShowingHands()                                  //change the layer's mask to show hand in order to help user to grab the handle
        {
            LeftHand.layer = LayerMask.NameToLayer("mouseSide");            
            RightHand.layer = LayerMask.NameToLayer("mouseSide");

            Transform childrenLeft = LeftHand.GetComponentInChildren<Transform>();
            foreach (Transform go in childrenLeft)
            {
                go.gameObject.layer = LayerMask.NameToLayer("mouseSide");
            }

            Transform childrenRight = RightHand.GetComponentInChildren<Transform>();
            foreach (Transform go in childrenRight)
            {
                go.gameObject.layer = LayerMask.NameToLayer("mouseSide");
            }
        }

        public void UnshowingHands()                     //change the layer's mask to show hide hands
        {
            LeftHand.layer = LayerMask.NameToLayer("Default");
            RightHand.layer = LayerMask.NameToLayer("Default");

            Transform childrenLeft = LeftHand.GetComponentInChildren<Transform>();
            foreach (Transform go in childrenLeft)
            {
                go.gameObject.layer = LayerMask.NameToLayer("Default");
            }

            Transform childrenRight = RightHand.GetComponentInChildren<Transform>();
            foreach (Transform go in childrenRight)
            {
                go.gameObject.layer = LayerMask.NameToLayer("Default");
            }
        }

      /*  public void OverKnees()
        {
            MeshHandler.enabled = !MeshHandler.enabled;
            PullToEJect.enabled = !PullToEJect.enabled;
            SubObjectHandler.GetComponent<Renderer>().material = YellowMaterial;
        }*/

        public void OverHead()
        {
            MeshHandler.enabled = !MeshHandler.enabled;
            PullToEJect.enabled = !PullToEJect.enabled;
            SubObjectHandler.GetComponent<Renderer>().material = YellowMaterial;
        }

     /*   public void GraspKnees()
        {
            SubObjectHandler.GetComponent<Renderer>().material = RedMaterial;
            co = StartCoroutine(CountDown());
        }*/

        public void GraspHead()
        {
            SubObjectHandler.GetComponent<Renderer>().material = RedMaterial;
            CountDown();
            //co = StartCoroutine(CountDown());
        }

      /*  public void GraspKneesRelease()                     //revert to original position and text
        {
            StopAllCoroutines();
            ShownText.text = "Pull to eject !";
            SubObjectHandler.GetComponent<Renderer>().material = YellowMaterial;
            SubObjectHandler.transform.position = originalPosition;
            SubObjectHandler.transform.rotation = Quaternion.identity;
        }*/

        public void GraspHeadRelease()                          //revert to original position and text
        {
            StopAllCoroutines();
            ShownText.text = "Pull to eject !";
            SubObjectHandler.GetComponent<Renderer>().material = YellowMaterial;
            SubObjectHandler.transform.position = originalPosition;
            SubObjectHandler.transform.rotation = Quaternion.identity; 
        }
    }
}

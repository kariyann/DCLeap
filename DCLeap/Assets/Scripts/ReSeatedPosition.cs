using UnityEngine;
using UnityRawInput;
using Valve.VR;

public class ReSeatedPosition : MonoBehaviour
{
    [Tooltip("Desired head position of player when seated")]
    public Transform desiredHeadPosition;  //correspond to the cockpit view reference position.
    public bool WorkInBackground = true;  //Need to be listening input cause DCS is in "foreground", so I use the RawKeyInput lib.

    private void Start()
    {
        RawKeyInput.Start(WorkInBackground); // Initialization of the listener "RawKeyInput".
    }
    // LateUpdate is called once at last frame
    void LateUpdate()
    {
        /*Specify the Space Key to send the recentering command,        
         * to specify the recentered position, we have to define the correct centered position in unity by creating the desiredHeadPosition object,
         * so we check if this default position is existing,
         * if OK we call 2 OpenVR functions to proceed the recentering action.
         */
        if (RawKeyInput.IsKeyDown(RawKey.Space))
        {
            if (desiredHeadPosition != null)
            {
                OpenVR.System.ResetSeatedZeroPose();
                OpenVR.Compositor.SetTrackingSpace(ETrackingUniverseOrigin.TrackingUniverseSeated);
                /* this is the crucial point, specification of TrackingUniverseSeated to specify that DCLeap is a seated experience,
                this avoid strange comportements of the overlay when ETrackingUniverseOrigin.UniverseStanding is used.
                 */
            }
            else
            {
                Debug.Log("Target Transform required. Assign in inspector.");                
            }
        }
    }

    private void OnDisable()
    {
        RawKeyInput.Stop();  // Stop the RawKeyInput "listener" when exiting DCLeap
    }
}

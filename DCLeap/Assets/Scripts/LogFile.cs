using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using Valve.VR;


namespace Leap.Unity
{
    public class LogFile : MonoBehaviour
    {
        public Unity_SteamVR_Handler steamVRChecker;
        public LeapXRServiceProvider controller;
        public VirtualMouse Lmouse;
        public VirtualMouse Rmouse;
        StreamWriter logFile;
        int LcursorPosX;
        int LcursorPosY;
        int RcursorPosX;
        int RcursorPosY;

        float waitTime=1.0f;
        float counter = 0.0f;
        float updateCounter = 0.0f;

        void Start()
        {
            LcursorPosX= 0;
            LcursorPosY = 0;
            RcursorPosX = 0;
            RcursorPosY = 0;
            string m_path = Application.dataPath + "/" + "LogFile.txt";
            if (File.Exists(m_path))
            {
                try
                {
                    File.Delete(m_path);

                    Debug.Log("file deleted");
                }
                catch (System.Exception e)
                {
                    Debug.LogError("cannot delete log file");
                }
            }
            logFile = new StreamWriter(m_path, true);
            WriteToLogFile();
        }

        public void WriteToLogFile()
        {
            float xSensitivity = PlayerPrefs.GetFloat("XSensitivity");
            float ySensitivity = PlayerPrefs.GetFloat("YSensitivity");
            int showHands = PlayerPrefs.GetInt("Show Hands");
            int xOffset = PlayerPrefs.GetInt("XOffset");
            int yOffset = PlayerPrefs.GetInt("YOffset");
            int debugText = PlayerPrefs.GetInt("DebugText");
            int debugMouse = PlayerPrefs.GetInt("DebugMouse");
            int pinch = PlayerPrefs.GetInt("PinchClick");
            int index = PlayerPrefs.GetInt("IndexClick");
            float lhNeutral = PlayerPrefs.GetFloat("LH Neutral");
            float rhNeutral = PlayerPrefs.GetFloat("RH Neutral");
            float activationSensitivity = PlayerPrefs.GetFloat("Activation sensitivity");
            int catAlign = PlayerPrefs.GetInt("CatAlign");
            int catShoot = PlayerPrefs.GetInt("CatShoot");
            int ejectionValue = PlayerPrefs.GetInt("Ejection");
            int autoStartValue = PlayerPrefs.GetInt("AutoStart");
            int screenW = Screen.currentResolution.width;
            int screenH = Screen.currentResolution.height;
            string date = System.DateTime.Now.ToString("yyyy/MM/dd_HH:mm:ss");

            logFile.WriteLine(date);
            logFile.WriteLine("*************************************************");
            logFile.WriteLine("-------------- System Informations --------------");
            logFile.WriteLine("*************************************************");
            logFile.WriteLine(SystemInfo.operatingSystem + "  |  " + SystemInfo.deviceType);
            logFile.WriteLine(SystemInfo.graphicsDeviceName);
            logFile.WriteLine("Screen_Width  :  " + screenW);
            logFile.WriteLine("Screen_Height :  " + screenH);
            logFile.WriteLine("*************************************************");
            logFile.WriteLine("----------------- Options datas -----------------");
            logFile.WriteLine("*************************************************");
            logFile.WriteLine("X_Sensitivity :  " + xSensitivity);
            logFile.WriteLine("Y_Sensitivity :  " + ySensitivity);
            logFile.WriteLine("ShowHands :  " + showHands);
            logFile.WriteLine("X_Offset :  " + xOffset);
            logFile.WriteLine("Y_Offset :  " + yOffset);
            logFile.WriteLine("Debug_Text :  " + debugText);
            logFile.WriteLine("Debug_Mouse :  " + debugMouse);
            logFile.WriteLine("Pinch :  " + pinch);
            logFile.WriteLine("Index :  " + index);
            logFile.WriteLine("LeftHandKnob_Neutral :  " + lhNeutral);
            logFile.WriteLine("RightHandKnob_Neutral :  " + rhNeutral);
            logFile.WriteLine("PinchActivation_Sensitivity :  " + activationSensitivity);
            logFile.WriteLine("CatAlign_HandSignal :  " + catAlign);
            logFile.WriteLine("CatShoot_HandSignal :  " + catShoot);
            logFile.WriteLine("Ejection_HandSignal :  " + ejectionValue);
            logFile.WriteLine("AutoStart_HandSignal :  " + autoStartValue);

            logFile.WriteLine("*************************************************");
            logFile.WriteLine("--------------- Services Status  ----------------");
            logFile.WriteLine("*************************************************");
            logFile.WriteLine("  TIME   |              LeapMotion Status               |    SteamVR Status    | LHand cursor (x;y) | RHand cursor (x;y)");

        }


        public void OnSteamVRConnect()
        {
            logFile.WriteLine(System.DateTime.Now.ToString("HH:mm:ss | ") + "Connected to SteamVR");
        }

        public void OnSteamVRDisconnect()
        {
            logFile.WriteLine(System.DateTime.Now.ToString("HH:mm:ss | ") + "Disconnected from SteamVR");
        }

        void Update()
        {
            LcursorPosX = (int)Lmouse.XLinearCalculation();
            LcursorPosY = (int)Lmouse.YLinearCalculation();
            RcursorPosX = (int)Rmouse.XLinearCalculation();
            RcursorPosY = (int)Rmouse.YLinearCalculation();

            if (updateCounter > waitTime)
            {
                if (controller.IsConnected() == true && steamVRChecker.SteamVRStartup() == true)
                {
                    logFile.WriteLine(System.DateTime.Now.ToString("HH:mm:ss | ") + "LeapMotion service is connected and running" + "  |  " + "STEAMVR is running" + "  |       " + LcursorPosX + ";" + LcursorPosY + "      |      " + RcursorPosX + ";" + RcursorPosY);
                }
                else if (controller.IsConnected() == true && steamVRChecker.SteamVRStartup() == false)
                {
                    logFile.WriteLine(System.DateTime.Now.ToString("HH:mm:ss | ") + "LeapMotion service is connected and running" + "  |  " + "ERROR !! STEAMVR is not running" + "  |       " + LcursorPosX + ";" + LcursorPosY + "      |      " + RcursorPosX + ";" + RcursorPosY);
                }
                else if (controller.IsConnected() == false && steamVRChecker.SteamVRStartup() == true)
                {
                    logFile.WriteLine(System.DateTime.Now.ToString("HH:mm:ss | ") + "ERROR !! LeapMotion is not connected" + "  |  " + "STEAMVR is running" + "  |       " + LcursorPosX + ";" + LcursorPosY + "      |      " + RcursorPosX + ";" + RcursorPosY);
                }
                else if (controller.IsConnected() == false && steamVRChecker.SteamVRStartup() == false)
                {
                    logFile.WriteLine(System.DateTime.Now.ToString("HH:mm:ss | ") + "ERROR !! LeapMotion is not connected" + "  |  " + "ERROR !! STEAMVR is not running" + "       |  " + LcursorPosX + ";" + LcursorPosY + "      |      " + RcursorPosX + ";" + RcursorPosY);
                }

                updateCounter = 0.0f;
            }
            counter += Time.deltaTime;
            updateCounter += Time.deltaTime;
        }

        private void OnDisable()
        {
            logFile.Close();
        }

    }
}


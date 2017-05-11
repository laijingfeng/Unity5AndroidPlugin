using UnityEngine;
using System;

public class Main : MonoBehaviour
{
    private string strTest = "Empty";

    void OnGUI()
    {
        GUILayoutOption[] options = new GUILayoutOption[2] { GUILayout.MinWidth(100), GUILayout.MinHeight(100) };
        
        GUILayout.Label(strTest, options);

        if (GUILayout.Button("CallAndroidFunc_GetInt", options))
        {
            strTest = UnityCallAnroid<int>("GetInt", false).ToString();
        }

        if (GUILayout.Button("CallAndroidFunc_GiveMeAMsg", options))
        {
            UnityCallAnroid("GiveMeAMsg", false);
        }
    }

    private void FuncA(string msg)
    {
        strTest = msg;
    }

    private void UnityCallAnroid(string methodName, bool isStatic = false, params object[] args)
    {
        AndroidJavaObject jo = GetAndroidJavaObject;
        if (jo == null)
        {
            return;
        }
        if (isStatic)
        {
            jo.CallStatic(methodName, args);
        }
        else
        {
            jo.Call(methodName, args);
        }
    }

    private T UnityCallAnroid<T>(string methodName, bool isStatic = false, params object[] args)
    {
        T ret = default(T);
        AndroidJavaObject jo = GetAndroidJavaObject;
        if (jo == null)
        {
            return ret;
        }
        if (isStatic)
        {
            ret = jo.CallStatic<T>(methodName, args);
        }
        else
        {
            ret = jo.Call<T>(methodName, args);
        }
        return ret;
    }

#if UNITY_ANDROID && !UNITY_EDITOR
    private AndroidJavaObject _androidJavaObject = null;
#endif
    private AndroidJavaObject GetAndroidJavaObject
    {
        get
        {
#if UNITY_ANDROID && !UNITY_EDITOR
            if (_androidJavaObject == null)
            {
                AndroidJavaClass jc = new AndroidJavaClass("com.unity3d.player.UnityPlayer");
                _androidJavaObject = jc.GetStatic<AndroidJavaObject>("currentActivity");
            }
            return _androidJavaObject;
#else
            return null;
#endif
        }
    }
}
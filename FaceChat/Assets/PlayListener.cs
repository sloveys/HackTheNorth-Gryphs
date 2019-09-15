using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayListener : MonoBehaviour
{
  public void PlayClick()
  {
    UnityEngine.XR.XRSettings.enabled = true;
    SceneManager.LoadScene(1, LoadSceneMode.Single);
  }
}

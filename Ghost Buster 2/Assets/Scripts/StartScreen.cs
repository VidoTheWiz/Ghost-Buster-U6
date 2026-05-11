using System.Collections;
using System.Collections.Generic;
using Meta.XR.MRUtilityKit.SceneDecorator;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartScreen : MonoBehaviour
{
    [Header("Settings")]
    [SerializeField] Transform targetCamera;
    [SerializeField] Vector3 cameraOffset = new Vector3(0, 0, 1.0f);
    private bool followRotation = true;
    // Update is called once per frame
    public void StartGame()
    {
        SceneManager.LoadScene("Game");
    }

    void LateUpdate()
    {
        if (targetCamera != null)
        {
            transform.position = targetCamera.TransformPoint(cameraOffset);

            if (followRotation)
            {
                transform.rotation = targetCamera.rotation;
            }
        }
    }
}
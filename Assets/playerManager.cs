
using System.Collections;
using Cinemachine;
using UnityEngine;
using UnityEngine.UI;

public class playerManager : MonoBehaviour
{
    public CinemachineVirtualCamera Camera;
    public Transform folowGameObj;
    public Button Correct;
    public Button Wrong;
    public GameObject decisionButton;
    

    void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("Collider entered: " + other.gameObject.name);
        switch (other.gameObject.tag)
        {
            case "Event":
                Camera.Follow =  folowGameObj;
                PlayerController.Instance.isMoving = false;
                StartCoroutine(DelayCoroutine1Second());
                StartCoroutine(DelayCoroutine3Second());
                break;

            case "Event2":
                PlayerController.Instance.isMoving = false;
               decisionButton.SetActive(true);
                break;

            // Add more cases for different scenarios if needed

            default:
               
                break;
        }
    }
    private IEnumerator DelayCoroutine1Second()
    {
        // Wait for 1 seconds
        yield return new WaitForSeconds(1f);
        
        Camera.Follow = transform;
    }
    private IEnumerator DelayCoroutine3Second()
    {
        // Wait for 1 seconds
        yield return new WaitForSeconds(3f);
        PlayerController.Instance.isMoving = true;
       
    }



}
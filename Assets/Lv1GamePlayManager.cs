
using System;
using System.Collections;
using Cinemachine;
using UnityEngine;
using UnityEngine.UI;

public class Lv1GamePlayManager : MonoBehaviour
{
    public CinemachineVirtualCamera Camera;
    public Transform folowGameObj;
   
    public GameObject decisionButton;
    public Animator PlayerAnim;
    public bool event3Reach;

    

    void OnTriggerEnter2D(Collider2D other)
    {
       
        switch (other.gameObject.tag)
        {
            case "Event":
                Camera.Follow =  folowGameObj;
                PlayerController.Instance.StopMoving();
                StartCoroutine(DelayCoroutine1Second());
                StartCoroutine(DelayCoroutine3Second());
                break;

            case "Event3":
                event3Reach= true;
                PlayerController.Instance.StopMoving();
                PlayerAnim.Play("Idle");
                
                 decisionButton.SetActive(true);
                
               
                
                break;

            // Add more cases for different scenarios if needed

            default:
               
                break;
        }
        
    }
    private void HandleRightClick()
    {
        decisionButton.SetActive(true);
        if (RightClick.Instance.IsRight)
        {
            PlayerAnim.Play("HappyJump");
            StartCoroutine(DelayCoroutine2Second());
            decisionButton.SetActive(false);
           
        }
    }

    private void HandleWrongClick()
    {
        if (WrongClick.Instance.wrongclicked)
        {
            PlayerAnim.Play("PlayerWalk");
            decisionButton.SetActive(false);
            PlayerController.Instance.StartMoving();
        }
    }

   
    void Update()
    {
        if (event3Reach)
        {
            HandleRightClick();
            HandleWrongClick();
        }
    }

    private IEnumerator DelayCoroutine1Second()
    {
        // Wait for 1 seconds
        yield return new WaitForSeconds(1f);
        PlayerAnim.Play("Idle");
        Camera.Follow = transform;
    }
    private IEnumerator DelayCoroutine3Second()
    {
        // Wait for 3 seconds
        yield return new WaitForSeconds(3f);
        PlayerController.Instance.StartMoving();
       
    }
    private IEnumerator DelayCoroutine2Second()
    {
        // Wait for 2 seconds
        yield return new WaitForSeconds(2f);
        PlayerAnim.Play("PlayerWalk");
        PlayerController.Instance.StartMoving(); 
       
    }



}
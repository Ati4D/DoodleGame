using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class First : MonoBehaviour
{
    
#region Init
    void Awake()
    {
        Debug.Log("Awake()");
    }
    void OnEnable()
    {
        Debug.Log("OnEnable()");
    } 
    void Start()
    {
        Debug.Log("Start()");
    }
#endregion
    
#region Update
    void FixedUpdate()
    {
        Debug.Log("FixedUpdate()");
    }
    void Update()
    {
        Debug.Log("Update()");
    }
    void LateUpdate()
    {
        Debug.Log("LateUpdate()");
    }
#endregion

    void OnApplicationPause()
    {
        
    }


    void OnDisable()
    {
        
    }
    
    void OnApplicationQuit()
    {
        
    }

    void OnDestroy()
    {
        
    }
    
}

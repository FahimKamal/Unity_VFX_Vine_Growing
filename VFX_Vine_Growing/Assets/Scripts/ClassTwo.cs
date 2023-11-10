using System;  
using UnityEngine;  
  
public class ClassTwo : MonoBehaviour  
{  
    // [SerializeField] private ClassOne classOne;  
  
    private void OnEnable(){  
        // First way (easiest).
        // classOne.OnFirstEvent += (sender, args) => {
        //     // Codes to executed on event trigger.
        // };
        //   
        // // Second way.
        // classOne.OnFirstEvent += delegate(object sender, EventArgs args){
        //     // Codes to executed on event trigger.
        // };  
		
        // Safest way to subscribe to any event.  
        // classOne.OnFirstEvent += ClassOne_OnFirstEvent;
        if (ClassOne.Instance != null){
            ClassOne.Instance.OnFirstEvent += ClassOne_OnFirstEvent;
        }
        
    }  
    
    private void OnDisable(){  
        // Safest way to unsubscribe to any event.  
        // classOne.OnFirstEvent -= ClassOne_OnFirstEvent;  
        if (ClassOne.Instance != null){
            ClassOne.Instance.OnFirstEvent -= ClassOne_OnFirstEvent;  
        }
    }

    private void Start(){
        if (ClassOne.Instance != null){
            ClassOne.Instance.OnFirstEvent += ClassOne_OnFirstEvent;
        }
    }

    private void ClassOne_OnFirstEvent(object sender, EventArgs e){  
        // Codes to executed on event trigger.
        Debug.Log("Event triggered. Class two");
    }
}
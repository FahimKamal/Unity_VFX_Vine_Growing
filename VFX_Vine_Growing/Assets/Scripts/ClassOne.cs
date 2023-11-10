using System;  
using UnityEngine;
using UnityEngine.UI;

public class ClassOne : MonoBehaviour{
    public static ClassOne Instance{ get; private set; }
    
    
    
    public event EventHandler OnFirstEvent;

    [SerializeField] private Button push;

    private void Awake(){
        Instance = this;
    
        push.onClick.AddListener(AnyRandomMethod);
    }

    private void AnyRandomMethod(){  
	    // Trigger the event.
        Debug.Log("Event triggered");
        OnFirstEvent?.Invoke(this, EventArgs.Empty);  
    }
}
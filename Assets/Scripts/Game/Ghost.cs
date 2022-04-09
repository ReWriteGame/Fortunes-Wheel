using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Ghost : MonoBehaviour
{
    public UnityEvent getBulletEvent;
    private void OnTriggerEnter2D(Collider2D col)
    {
        if(col.gameObject.GetComponent<Bull>())
            getBulletEvent?.Invoke();
    }
}

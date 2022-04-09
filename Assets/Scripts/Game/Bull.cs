using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Bull : MonoBehaviour
{
  public UnityEvent getGhostEvent;
  private void OnTriggerEnter2D(Collider2D col)
  {
    if(col.gameObject.GetComponent<Ghost>())
      getGhostEvent?.Invoke();
  }
}

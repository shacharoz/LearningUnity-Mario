using UnityEngine;
using UnityEngine.Events;

public class TriggerManager : MonoBehaviour
{
    public string TagName;

    public UnityEvent OnHitTarget;

    void Start()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag.Contains(TagName))
        {
            //do something
            OnHitTarget.Invoke();
        }
    }
}
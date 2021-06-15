using UnityEngine;
using UnityEngine.Events;

public class CollisionManager : MonoBehaviour
{
    public string TagName;

    public UnityEvent OnHitTarget;

    void Start()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag.Contains(TagName))
        {
            //do something
            OnHitTarget.Invoke();
        }
    }
}

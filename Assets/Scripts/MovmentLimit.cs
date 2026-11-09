using UnityEngine;

public class MovmentLimit : MonoBehaviour
{
    [SerializeField] float limiteMax = 4;
    [SerializeField] float limiteMin = -4;


    void Start()
    {
        
    }

    void Update()
    {
        if(transform.position.y > limiteMax)
        {
           Vector3 newpos = transform.position;
            newpos.y = limiteMax;
            transform.position = newpos;    
        }
        if (transform.position.y < limiteMin)
        {
            Vector3 newpos = transform.position;
            newpos.y = limiteMin;
            transform.position = newpos;
        }


    }
}

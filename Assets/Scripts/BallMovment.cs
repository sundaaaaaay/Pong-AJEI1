using UnityEngine;

public class BallMovment : MonoBehaviour
{
    [SerializeField] private float ballSpeed = 5;
    Vector3 dir;


    void Start()
    {
        Vector3 dir = new Vector3(
            Random.Range(-1f, 1f), 
            Random.Range(-1f, 1f)
        );
    }

    void Update()
    {
        Debug.Log(Random.Range(-1f, 1f));
        //Vector3 dir = new Vector3(1, 1);
        transform.position = transform.position + dir * ballSpeed * Time.deltaTime;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("HE ATRAVESADO ALGO");
    }
}

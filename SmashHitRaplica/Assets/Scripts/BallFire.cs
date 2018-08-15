using UnityEngine;
using System.Collections;

public class BallFire : MonoBehaviour
{
    public GameObject particle;
    private GameObject ball;
    private Vector3 newPosition;
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            ////Vector3 mouseWorld = Camera.main.ScreenToWorldPoint(Input.mousePosition);

            ////Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            ball = Instantiate(particle, transform.position, transform.rotation) as GameObject;
            ////transform.position = mouseWorld;
            ////ball.GetComponent<Rigidbody>().AddForce(0, 5, 200);

            //newPosition.x = Input.mousePosition.x;
            //newPosition.y = Input.mousePosition.y;
            //newPosition = new Vector3(newPosition.x, newPosition.y, 0);
            ////Vector3 mouseWorld = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            //Vector3 dir = (transform.position - newPosition).normalized;
            //Debug.Log(newPosition);
            ////ball.GetComponent<Rigidbody>().AddForce(dir * 300);
            //ball.transform.position = newPosition;

            //RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            //if (Physics.Raycast(ray, out hit))
            //{
            //    newPosition = hit.point;
            //    //transform.position = newPosition;
            //    Debug.Log(newPosition);
            //}

            //Vector3 pz = Camera.main.ScreenToWorldPoint(Input.mousePosition);

            Debug.Log(ray.origin);
            //ball.transform.position = ray.origin;
            Vector3 dir = (transform.position - ray.origin).normalized;
            dir.x = -dir.x;
            dir.y = -dir.y;
            ball.GetComponent<Rigidbody>().AddForce(dir * 300);
            Debug.Log(dir);
        }
    }
}
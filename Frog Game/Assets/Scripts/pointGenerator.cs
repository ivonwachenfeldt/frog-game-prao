using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class pointGenerator : MonoBehaviour
{
    public Vector2 mousePos;
    public List<Vector2> points = new List<Vector2>();
    public GameObject sq;
    public List<GameObject> squares = new List<GameObject>();
    Vector2 velocity = new Vector2(0, 0);

    public LineRenderer lineR;
    public EdgeCollider2D edgeCol;

    public List<Vector3> cubePositions = new List<Vector3>();

    public bool clickable = true;

    void Start()
    {

    }

    void Update()
    {
        if (clickable)
            if (Input.GetKey(KeyCode.Mouse0))
            {

                mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

                if (points.Count == 0)
                    points.Add(new Vector2(0, -4));
                else
                    points[0] = new Vector2(0, -4);


                if (Vector2.Distance(mousePos, points[points.Count - 1]) > 1f)
                {
                    if (points.Count < 40)
                    {
                        Vector2 dir = (mousePos - points[points.Count - 1]);

                        points.Add(points[points.Count - 1] + (dir.normalized * 0.5f));

                        squares.Add(Instantiate(sq, points[points.Count - 1], transform.rotation));
                    }

                }
            }
        for (int i = 0; i < squares.Count; i++)
        {
            if (Vector2.Distance(squares[i].transform.position, new Vector2(0, -4)) < 0.3f)
            {
                Destroy(squares[i]);
                squares.Remove(squares[i]);
                points.Remove(points[i]);
            }
        }
        if (Input.GetMouseButtonUp(0))
            clickable = false;


        cubePositions = squares.Select(f => f.transform.position).ToList();

        lineR.positionCount = cubePositions.Count;
        lineR.SetPositions(cubePositions.ToArray());
        edgeCol.points = ConvertArray(cubePositions.ToArray());

        if (points.Count <= 1)
            clickable = true;
    }


    Vector2[] ConvertArray(Vector3[] v3)
    {
        Vector2[] v2 = new Vector2[v3.Length];
        for (int i = 0; i < v3.Length; i++)
        {
            Vector3 tempV3 = v3[i];
            v2[i] = new Vector2(tempV3.x, tempV3.y);
        }
        return v2;
    }
}

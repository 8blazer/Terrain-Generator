using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TerrainScript : MonoBehaviour
{
   /* public Sprite fullDirt;
    public Sprite topGrass;
    public Sprite rightGrass;
    public Sprite leftGrass;
    public Sprite bottomGrass;
    public Sprite TRGrass; //top right
    public Sprite BRGrass; //bottom right
    public Sprite TLGrass; //top left
    public Sprite BLGrass; //bottom left
    public Sprite RLGrass; // right left
    public Sprite TBGrass; //top bottom
    public Sprite TRBGrass; //top right bottom
    public Sprite TLBGrass; //top left bottom
    public Sprite TRLGrass; //top right left
    public Sprite RLBGrass; //right left bottom
    public Sprite fullGrass;

    public Sprite RCornerGrass;
    public Sprite LCornerGrass;
    public Sprite TCornerGrass;
    public Sprite BCornerGrass;
    public Sprite TRCornerGrass;
    public Sprite BRCornerGrass;
    public Sprite TLCornerGrass; //top left
    public Sprite BLCornerGrass; //bottom left
    public Sprite RLCornerGrass; // right left
    public Sprite TBCornerGrass; //top bottom
    public Sprite TRBCornerGrass; //top right bottom
    public Sprite TLBCornerGrass; //top left bottom
    public Sprite TRLCornerGrass; //top right left
    public Sprite RLBCornerGrass; //right left bottom
    public Sprite fullCornerGrass; */

    public GameObject dirtPrefab;
    public GameObject grassPrefab;
    System.Random rnd = new System.Random();
    int prevNumber = 0;
    int number = 1;
    float x = -7.5f;
    float y = 3.5f;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 128; i++)
        {
            int rndNumber = rnd.Next(1, 3);
            if (rndNumber == 1)
            {
                Instantiate(dirtPrefab, new Vector3(x, y, 0), Quaternion.identity);
            }
            if (x == 7.5f)
            {
                x = -7.5f;
                y--;
            }
            else
            {
                x++;
            }
        }
        x = -8.5f;
        y = 3.5f;
        transform.position = new Vector3(x, y, 0);
    }

    // Update is called once per frame
    void Update()
    {
        if (prevNumber != number)
        {
            prevNumber++;
            if (x == 7.5f)
            {
                x = -7.5f;
                y--;
            }
            else
            {
                x++;
            }
            transform.position = new Vector3(x, y, 0);
        }
    }
}

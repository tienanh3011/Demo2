using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    //private int i = 0;
    public float speed = 10f;
    public float speedjump = 10f;
    private bool isJump;
    private bool isFall;
    
    //di chuyen tu do hinh chu nhat
    //Vector2 target;
    //private bool isPos0, isPos1, isPos2, isPos3;
    //public Transform pos0;
    //public Transform pos1;
    //public Transform pos2;
    //public Transform pos3;
    // Start is called before the first frame update
    void Start()
    {
        //Debug.Log("======== Ham Start");
        //isPos0 = false;
        //isPos1 = true;
        //isPos2 = false;
        //isPos3 = false;
        isFall = false;
        isJump = false;
        transform.position = new Vector2(-12.7f, -4.66f);
    }
    //Time.delta la thoi gian giua 2 frame
    // Update is called once per frame
    void Update()
    {
        //transform.Translate(Vector2.left * speed * Time.deltaTime);
        //transform.Translate(Vector2.up * speed * Time.deltaTime);
        //transform.Translate(Vector2.right * speed * Time.deltaTime);
        //transform.Translate(Vector2.down * speed * Time.deltaTime);


        //Vector2 _pos = transform.localScale;
        //float step = 1.0f;
        //di chuyen phim mui ten
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            
            isJump = true;
        }
        if (isJump)
        {
            transform.Translate(Vector2.up * speedjump * Time.deltaTime);
        }
        if (transform.position.y>=0)
        {

            isFall = true;
            isJump = false;
        }
        if(isFall)
        {
            transform.Translate(Vector2.down * speedjump * Time.deltaTime);
        }
        if (transform.position.y < -4.66f)
        {

            transform.position = new Vector2(transform.position.x, -4.66f);
            isFall = false;
        }
        //if (Input.GetKeyDown(KeyCode.DownArrow))
        //{
        //    transform.Translate(Vector2.down * speed * Time.deltaTime);

        //}
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(Vector2.left * speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(Vector2.right * speed * Time.deltaTime);
        }

        //_pos.y-=step
        //di chuyen tu do hinh chu nhat
        //  if(isPos1)
        //  {
        //      target = pos1.position;
        //       if(Vector2.Distance(transform.position,pos1.position)<0.1f)
        //      {
        //          isPos0 = false;
        //          isPos1 = false;
        //          isPos2 = true;
        //          isPos3 = false;
        //      }

        //  }
        //  if (isPos2)
        //  {
        //      target = pos2.position;
        //       if (Vector2.Distance(transform.position, pos2.position) < 0.1f)
        //      {
        //          isPos0 = false;
        //          isPos1 = false;
        //          isPos2 = false;
        //          isPos3 = true;
        //      }

        //  }
        //  if (isPos3)
        //  {
        //      target = pos3.position;
        //       if (Vector2.Distance(transform.position, pos3.position) < 0.1f)
        //      {
        //          isPos0 = true;
        //          isPos1 = false;
        //          isPos2 = false;
        //          isPos3 = false;
        //      }

        //  }
        //  if (isPos0)
        //  {
        //      target = pos0.position;
        //       if (Vector2.Distance(transform.position, pos0.position) < 0.1f)
        //      {
        //          isPos0 = false;
        //          isPos1 = true;
        //          isPos2 = false;
        //          isPos3 = false;
        //      }

        //  }
        //transform.position = Vector2.MoveTowards(transform.position, target, speed * Time.deltaTime);

    }
}

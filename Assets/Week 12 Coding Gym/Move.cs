using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class Move : MonoBehaviour
{
    public float moveSpeed = 3f;
    public Tilemap tilemap;
    public TileBase grassTile;

    private Vector3 targetPos;
    private bool isMoving = false;

    private Animator animator;
    private SpriteRenderer spriteRenderer;

    void Start()
    {
        targetPos = transform.position;
        animator = GetComponent<Animator>();
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 mouseWorld = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            mouseWorld.z = 0;
            // int Tilemap
            Vector3Int gridPos = tilemap.WorldToCell(mouseWorld);

            // chack Tilemap
            TileBase clickedTile = tilemap.GetTile(gridPos);

            if (clickedTile == grassTile)
            {
                Debug.Log("That's the grass! Don't go!");
                return;
            }

            // change to the center
            targetPos = tilemap.GetCellCenterWorld(gridPos);
            isMoving = true;
        }

        if (isMoving)
        {
            transform.position = Vector3.MoveTowards(transform.position, targetPos, moveSpeed * Time.deltaTime);

            // flips x
            if (targetPos.x < transform.position.x)
                spriteRenderer.flipX = true;
            else if (targetPos.x > transform.position.x)
                spriteRenderer.flipX = false;

            animator.SetBool("isRunning", true);

            if (Vector3.Distance(transform.position, targetPos) < 0.01f)
            {
                isMoving = false;
                animator.SetBool("isRunning", false);
            }
        }
        else
        {
            animator.SetBool("isRunning", false);
        }
    }
}
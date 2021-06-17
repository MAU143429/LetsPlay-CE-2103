using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bp_matrix 
{
    public static int ROWS = 12;
    public static int COLS = 17;
    public static float box_dimensionx = 1;
    public static float box_dimensiony = 0.7454f;
    public static int cell_x;
    public static int cell_y;
    public static List<List<bp_box>> bp_matrix = new List<List<bp_box>>();

    public static void Create_Matrix()
    {
        for (int i = 0; i < ROWS; i++)
        {
            List<bp_box> row = new List<bp_box>();
            for (int j = 0; j < COLS; j++)
            {
                bp_box newvalue = new bp_box();
                row.Add(newvalue);
            }
            bp_matrix.Add(row);
        }
    }

    public static void Fill_Matrix()
    {
        Create_Matrix();
        float max_width = -8;
        float max_height = 4.10f;

        for (int i = 0; i < ROWS; i++)
        {
            for (int j = 0; j < COLS; j++)
            {
                bp_matrix[i][j].posx = max_width;
                bp_matrix[i][j].posy = max_height;
                bp_matrix[i][j].i = i;
                bp_matrix[i][j].j = j;

                max_width += box_dimensionx; 
            }

            max_height -= box_dimensiony;
            max_width = -8;
        }


    }

    public static void Identify_Cell()
    {
        float ball_positionx = GameManager.Ball.x;
        float ball_positiony = GameManager.Ball.y;
        Debug.Log("LA POSICION X DE LA BOLA ES: " + ball_positionx);
        Debug.Log("LA POSICION Y DE LA BOLA ES: " + ball_positiony);
        float halfx = 0.50f;
        float halfy = 0.3727f;
        

        for (int i = 0; i < ROWS; i++)
        {
            for (int j = 0; j < COLS; j++)
            {
               
                 
                if( (ball_positionx > (bp_matrix[i][j].posx - halfx)) && (ball_positionx < (bp_matrix[i][j].posx + halfx)) &&
                    (ball_positiony > (bp_matrix[i][j].posy - halfy)) && (ball_positiony < (bp_matrix[i][j].posy + halfy)))
                {
                    cell_x = bp_matrix[i][j].i;
                    cell_y = bp_matrix[i][j].j;
                    
                    

                }
                
                    
            }
        }
        
        
    }
   


}

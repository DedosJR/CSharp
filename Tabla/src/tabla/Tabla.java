/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Main.java to edit this template
 */

package tabla;
import java.util.Scanner;
/**
 *
 * @author Dedosjr
 */
public class Tabla {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        Scanner scn= new Scanner (System.in);
        int tab;
        
        System.out.print("Ingrese la tabla a multiplicar");
        tab = scn.nextInt();
        
        
        for (tab= 1; tab<=10; tab++);
        System.out.print(""+tab);
    }
    
}

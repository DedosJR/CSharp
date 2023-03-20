/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Main.java to edit this template
 */

package prog1;

/**
 *
 * @author Dedosjr
 */
public class Prog1 {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
      
      double art1,art2,art3,total,sub,iva;
     art1 = 15.00;
     art2 = 60.00;
     art3 = 12.50;
     iva = 0.08;
        
        sub = art1 + art2 + art3;
         iva = sub * iva ;
         total = sub+ iva;
         
         System.out.println("El Subtotal  de su compra es :" + sub);
         System.out.println("El IVA de su compra es :" + iva);
       System.out.println("El total de su compra es :"+ total);
      
     
    }
    
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AppVector
{
    class clsVector
    {
        private int[] vector;
        private int lg;
        //constructor
        public clsVector() { 
        vector= new int [100];
        lg = 0;
        }
        //metodos (procedimiento y funciones)
        public void adicionar(int valor) {
            vector[lg] = valor;
            lg = lg + 1;
        }
        //obtener el valor en la posicion pos
        public int obtenervalor(int pos) {
            return vector[pos];
        }
        // Longitud del vector
        public int longitud() {
            return lg;
        }
        //invertir los elementos del vector
        public void invertir(){
            int fin = lg-1;
            int mitad = lg / 2;
            int i = 0;
            int aux = 0;
            while (i < mitad) {
                aux = vector[fin - i];
                vector[fin - i] = vector[i];
                vector[i] = aux;
                i++;
            }                

       
        }

        //cantidad de elementos pares
        public int cantPares(){
            int cont = 0;
            for (int i = 0; i < lg; i++)
            {
                if (vector[i] % 2 == 0)
                    cont++;
            }
            return cont;


      

       }
    }


}

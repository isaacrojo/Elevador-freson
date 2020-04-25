using System;
using System.Collections.Generic;


namespace Elevador__linked_list_
{
    class Elevator
    {
        LinkedList<int> pisos = new LinkedList<int>(new int[] {1, 2, 3, 4, 5, 6, 7});

        LinkedListNode<int> pisoActual = null;
        bool elevadorHabilitado = false;

        public Elevator() {
            //LinkedListNode<int>
            //El elevador comienza en el primer piso
            pisoActual = pisos.First;
        }

        public void PedirElevador(int pisoDestino) {
            elevadorHabilitado = true;
            this.IrAPiso(pisoDestino);
            elevadorHabilitado = true;
        }

        public void IrAPiso(int pisoDestino) {

            if (!elevadorHabilitado)
            {
                System.Console.WriteLine("No se ha pedido el elevador!");
                return;
            }

            //TODO: Validar que el piso destino sea válido
            System.Console.WriteLine($"Estoy en piso {pisoActual.Value}, voy a piso {pisoDestino}");

            //Si el número de piso destino es igual al actual, no tenemos que movernos
            if (pisoDestino == pisoActual.Value)
            {
                System.Console.WriteLine("Elevador no necesita moverse, ha llegado a su destino.");
                elevadorHabilitado = false;
                return;
            }
            //Si el número de piso destino es más alto, debemos subir
            if (pisoDestino > pisoActual.Value)
            {
                while (pisoDestino != pisoActual.Value) {
                    pisoActual = pisoActual.Next;
                    System.Console.WriteLine($"piso actual => {pisoActual.Value}");
                }
                System.Console.WriteLine("Elevador ha llegado a su destino.");
                elevadorHabilitado = false;
                return;
            } else {
                //Si el número de piso destino es más bajo, debemos bajar
                while (pisoDestino != pisoActual.Value) {
                    pisoActual = pisoActual.Previous;
                    System.Console.WriteLine($"piso actual => {pisoActual.Value}");
                }
                System.Console.WriteLine("Elevador ha llegado a su destino.");
                elevadorHabilitado = false;
                return;
            }
        }
    }
}
          
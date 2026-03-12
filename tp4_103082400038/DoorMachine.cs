using System;
using System.Collections.Generic;
using System.Text;

namespace tp4_103082400038
{
    class DoorMachine
    {
        enum State
        {
            Terkunci,
            Terbuka
        }

        private State currentState;

        public DoorMachine()
        {
            currentState = State.Terkunci;
            Console.WriteLine("Pintu terkunci");
        }

        public void Buka()
        {
            if (currentState == State.Terkunci)
            {
                currentState = State.Terbuka;
                Console.WriteLine("Pintu tidak terkunci");
            }
        }

        public void Kunci()
        {
            if (currentState == State.Terbuka)
            {
                currentState = State.Terkunci;
                Console.WriteLine("Pintu terkunci");
            }
        }
    }
}

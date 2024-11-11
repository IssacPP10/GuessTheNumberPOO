using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessTheNumberPOO
{
    public class Game
    {
        private int targetNumber;  // Número aleatorio a adivinar
        private int attempts;      // Número de intentos realizados

        public Game()
        {
            Random random = new Random();
            targetNumber = random.Next(1, 101);  // Genera un número entre 1 y 100
            attempts = 0;
        }

        public void Play()
        {
            int guess = 0;
            Console.WriteLine("Bienvenido al juego de adivinar el número!");
            Console.WriteLine("He elegido un número entre 1 y 100. ¿Puedes adivinarlo?");

            Console.WriteLine($"El número que debes adivinar es {targetNumber}");
            // Loop hasta que el jugador adivine el número
            while (guess != targetNumber) 
            {
                Console.WriteLine("Introduce tu intento: ");
                string input = Console.ReadLine();

                if (!int.TryParse(input, out guess))  
                {
                    Console.WriteLine("Por favor, introduce un número válido.");
                    continue;
                }

                attempts++;

                if (guess < targetNumber)
                {
                    Console.WriteLine("El número es mayor.");
                }
                else if (guess > targetNumber)
                { 
                    Console.WriteLine("El número es menor.");
                }
                else 
                { 
                    Console.WriteLine($"¡Felicidades! Adivinaste el número en {attempts} intentos.");
                }

            }
        }
    }
}

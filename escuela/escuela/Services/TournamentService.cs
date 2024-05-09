using escuela.Enums;
using escuela.Models;
using System;
using System.Collections.Generic;
using System.Reflection;

namespace escuela.Services
{
    public class TournamentService
    {
        public Tournament CreateTournament(List<TennisPlayer> players)
        {
            // Selecciona tipo de torneo
            var tournamentGender = GetGenderTournament();

            // Generar aleatoriamente el número de jugadores (potencia de 2)
            var numberOfPlayers = GetRandomNumberOfPlayers();

            // Generar un nombre de torneo aleatorio
            var tournamentName = GetRandomTournamentName();

            // Crear instancia de Tournament
            var tournament = new Tournament
            {
                TournamentGender = tournamentGender,
                Players = players
            };

            return tournament;
        }

        private Gender GetGenderTournament()
        {
            Console.WriteLine("Por favor, seleccione el género del torneo:");
            Console.WriteLine("1. Masculino");
            Console.WriteLine("2. Femenino");
            Console.Write("Opción: ");

            // Leer la selección del usuario
            int option;
            while (!int.TryParse(Console.ReadLine(), out option) || option < 1 || option > 2)
            {
                Console.WriteLine("Opción inválida. Por favor, seleccione 1 para Masculino o 2 para Femenino.");
                Console.Write("Opción: ");
            }
            return (option == 1) ? Gender.Male : Gender.Female;
        }

        private int GetRandomNumberOfPlayers()
        {
            var random = new Random();
            int exponent = random.Next(3, 6); // Exponente entre 3 y 5 para obtener números entre 8 y 32
            return (int)Math.Pow(2, exponent);
        }
        
        private string GetRandomTournamentName()
        {
            var tournamentNames = Enum.GetValues(typeof(Enums.TournamentNames));
            var random = new Random();
            var randomIndex = random.Next(tournamentNames.Length);
            return tournamentNames.GetValue(randomIndex).ToString();
        }  
    }
}

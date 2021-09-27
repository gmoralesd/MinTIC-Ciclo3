using System;
using popcorntime.Shared.Entity;
using System.Collections.Generic;
namespace popcorntime.Client.Services
{
    public class ServiceMovie : IServiceMovie
    {
        public List<Movie>GetMovies(){
            return new List<Movie>(){
                new Movie(){MovieName="Oblivion", Image="images/uploads/slider1.jpg", Score="7.0",Category="Acion",Synopsis="Hace 60 años la Tierra quedó devastada tras la guerra con los alienígenas. A día de hoy, sus únicos habitantes son Jack Harper, que hace 'drones' que extraen recursos para la colonia humana en Titán, y Victoria Olsen, responsable de comunicaciones.", Premier= new DateTime(2021,09,24)},
                new Movie(){MovieName="Camino salvaje", Image="images/uploads/slider2.jpg", Score="8.1",Category="Aventura",Synopsis="Christopher McCandless, un estudiante de 10, abandona todas sus posesiones, dona sus ahorros a la caridad y hace autoestop hasta llegar a Alaska para vivir en una zona selvática.", Premier= new DateTime(2021,09,24)},
                new Movie(){MovieName="Blade Runner 2049", Image="images/uploads/slider3.jpg", Score="8.0",Category="Sci-Fi",Synopsis="Tras la rebelión de los replicantes creados por bioingeniería para ser utilizados como mano de obra esclava y la prohibición a Tyrell Corporation de seguir con su fabricación, el empresario Niander Wallace adquirió lo que quedaba de Tyrell Corp. y creó una nueva línea de replicantes mucho más obedientes.", Premier= new DateTime(2021,09,24)},
                new Movie(){MovieName="Rogue One", Image="images/uploads/slider4.jpg", Score="7.9",Category="Acion",Synopsis="", Premier= new DateTime(2021,09,24)},
                new Movie(){MovieName="Interstellar", Image="images/uploads/slider5.jpg", Score="8.6",Category="Sci-Fi",Synopsis="", Premier= new DateTime(2021,09,24)},
                new Movie(){MovieName="El origen", Image="images/uploads/slider6.jpg", Score="8.8",Category="Aventura",Synopsis="", Premier= new DateTime(2021,09,24)},
                new Movie(){MovieName="Dune", Image="images/uploads/slider7.jpg", Score="8.5",Category="Aventura",Synopsis="", Premier= new DateTime(2021,09,24)},
                new Movie(){MovieName="Ford vs Ferrari", Image="images/uploads/slider8.jpg", Score="8.1",Category="Drama",Synopsis="", Premier= new DateTime(2021,09,24)},
                new Movie(){MovieName="Into the spider verse", Image="images/uploads/slider9.jpg", Score="8.4",Category="Animacion",Synopsis="", Premier= new DateTime(2021,09,24)},
                new Movie(){MovieName="Your Name", Image="images/uploads/slider10.jpg", Score="8.4",Category="Animacion",Synopsis="", Premier= new DateTime(2021,09,24)}
            };
        }
    }
}
using System;
using System.Collections.Generic;
using System.Text;

namespace Moobi
{
    public class Pelicula
    {
        public string Nombre { get; set; }

        public string Duracion { get; set; }

        public string Director { get; set; }

        public int CalificacionRT { get; set; }

        public bool EsFavorita { get; set; }

        public string Protagonistas { get; set; }

        public string Sinopsis { get; set; }

        public string Clasificacion { get; set; }

        public string TipoSala { get; set; }

        // *****************************

        public string RecipeName { get; set; }

        public string PreparationTime { get; set; }

        public string CookTime { get; set; }

        public int NumberOfServings { get; set; }

        public bool WillMakeAgain { get; set; }

        public string MealType { get; set; }

        public string Difficulty { get; set; }

        public string Ingredients { get; set; }

        public string Directions { get; set; }
    }




    /** Using the two classes below to set the pickers off of
		Due to pickers being unable to bind to enums, these will
		serve as an enum for the TipoSala and Clasificacion properties
		of the Pelicula class **/
    public static class Clasificacion
    {
        public static string A = "Clasificación A";
        public static string B = "Clasificación B";
        public static string C = "Clasificación C";

        public static string Easy = "Easy";
        public static string Medium = "Medium";
        public static string Hard = "Hard";
    }

    public static class TipoSala
    {
        public static string SalaRegular = "Sala Regular";
        public static string SalaVIP = "Sala VIP";
        public static string Sala4DX = "Sala 4DX";
        public static string SalaKids = "Sala Kids";

        public static string Breakfast = "Breakfast";
        public static string Lunch = "Lunch";
        public static string Dinner = "Dinner";
        public static string Snack = "Snack";
    }
}

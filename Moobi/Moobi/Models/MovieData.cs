using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Moobi
{
    public static class MovieData
    {
        static List<Pelicula> _allMovies;
        public static List<Pelicula> AllMovies
        {
            get
            {
                if (_allMovies == null)
                {
                    _allMovies = new List<Pelicula>
                    {
                        new Pelicula {
                            Nombre="Avengers Infinity War",
                            Duracion="120",
                            Director="George Lucas",
                            CalificacionRT=10,
                            EsFavorita = true,
                            Protagonistas = "Robert Downey Jr., Chris Hemsworth, Thanos",
                            Sinopsis="Thanos Thanos Thanos Thanos Thanos Thanos\nIron Man Iron Man Iron Man Iron Man Iron Man",
                            Clasificacion=Clasificacion.B,
                            TipoSala=TipoSala.Sala4DX
                        },
                        new Pelicula {
                            Nombre="Solo: A Star Wars Story",
                            Duracion="90",
                            Director="George Lucas",
                            CalificacionRT=4,
                            EsFavorita = false,
                            Protagonistas = "Un vato, Emilia Clarke <3, Chewbacca",
                            Sinopsis="Chewbacca\n GRRRRRRRRRRRRRRRR",
                            Clasificacion=Clasificacion.A,
                            TipoSala=TipoSala.SalaKids
                        },
                        new Pelicula {
                            Nombre="Psicópata Americano",
                            Duracion="120",
                            Director="George Lucas",
                            CalificacionRT=10,
                            EsFavorita = true,
                            Protagonistas = "Christian Bale",
                            Sinopsis="Un yuppie de los 80's asesina a mendigos por placer (y prostitutas hehehe).",
                            Clasificacion=Clasificacion.C,
                            TipoSala=TipoSala.SalaRegular
                        }
                    };
                }
                return _allMovies;
            }
        }

        static List<MovieGrouping> _allMoviesGrouped;
        public static List<MovieGrouping> AllMoviesGrouped
        {
            get
            {
                if (_allMoviesGrouped == null)
                {
                    var AGrouping = new MovieGrouping("Clasificación A", "A");
                    AGrouping.AddRange(MovieData.AllMovies.Where(r => r.Clasificacion == Clasificacion.A));

                    var BGrouping = new MovieGrouping("Clasificación B", "B");
                    BGrouping.AddRange(MovieData.AllMovies.Where(r => r.Clasificacion == Clasificacion.B));

                    var CGrouping = new MovieGrouping("Clasificación C", "C");
                    CGrouping.AddRange(MovieData.AllMovies.Where(r => r.Clasificacion == Clasificacion.C));

                    _allMoviesGrouped = new List<MovieGrouping> {
                        AGrouping,
                        BGrouping,
                        CGrouping
                    };
                }

                return _allMoviesGrouped;
            }
        }
    }
}

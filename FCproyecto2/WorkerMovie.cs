using System;
using System.Collections.Generic;
namespace FCproyecto2

{
    public class WorkerMovie
    {
        private string Name;
        private string LastName;
        private string StageName;
        private string Workermovierol;
        private float RankingWM;
        private int Edadtrabajador;
        private string Sexotrabajador;
        List<Movies> MoviesIn = new List<Movies> { }; //lista de peliculas en las que esta el trabajador
        List<Profile> WorkerMovieFollowers = new List<Profile>; //lista de perfil que siguen al trabajador

        public WorkerMovie(string name,string lastname,string stagename,string workermovierol,float rankingwm, int edadtrabajador,string sexotrabajador)
        {
            this.Name = name;
            this.LastName = lastname;
            this.StageName = stagename;
            this.Workermovierol = workermovierol;
            this.RankingWM = rankingwm;
            this.Edadtrabajador = edadtrabajador;
            this.Sexotrabajador = sexotrabajador;

        }
        public string InfoWorkerMovie()
        {
            return "Nombre: " + Name + ", Apellido: " + LastName + ", NombreArtistico: " + StageName + ", Rol: " + Workermovierol + ", Ranking: " + RankingWM + ", Edad: " + Edadtrabajador + ", Sexo: " + Sexotrabajador;
        }
        public void AddMoviesIn(Movies pelicula) //metodo para agregar a la lista las peliculas en la cual participa el trabajador
        {
            MoviesIn.Add(pelicula);

        }
        public void AddWorkerMovieFollowers(Profile perfil) //metodo para añadir los perfiles que siguen al trabajador
        {
            WorkerMovieFollowers.Add(perfil);
        }


    }
}

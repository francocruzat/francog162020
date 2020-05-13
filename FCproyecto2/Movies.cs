using System;
using System.Collections.Generic;
namespace FCproyecto2
{
    public class Movies
    {
        public string Title;
        public string Category;
        public string DurationM;
        public float RankingM;
        public string YearPublishM;
        public string MovieQuality;
        public string MovieSize;
        public string Description;
        public int LikesM;
        public int ReproductionsM;
        public string TypeFileM;
        public string Studio;
        public string MovieImage;
        public List<WorkerMovie> Cast;//lista workermovie(trabajador de peliculas)

        public Movies(string title, string category, string durationm, float rankingm, string yearpublishm, string moviequality, string moviesize, string description, int likesm, int reproductionsm, string typefilem, string studio, string movieimage)
        {
            this.Title = title;
            this.Category = category;
            this.DurationM = durationm;
            this.RankingM = rankingm;
            this.YearPublishM = yearpublishm;
            this.MovieQuality = moviequality;
            this.MovieSize = moviesize;
            this.Description = description;
            this.LikesM = likesm;
            this.ReproductionsM = reproductionsm;
            this.TypeFileM = typefilem;
            this.Studio = studio;
            this.MovieImage = movieimage;

        }
        public void Anadirtrabajador(WorkerMovie trabajador)
        {
            Cast.Add(trabajador);
        }
        public string InfoMovie()
        {

            return "Titulo: " + Title + ", Categoria: " + Category + ", Duracion: " + DurationM + ", Ranking: " + RankingM + ", Año de publicacion: " + YearPublishM + ", Likes: " + LikesM + ", Reproducciones: " + ReproductionsM + ", Estudio: " + Studio +;

        }
        public string Descripcion()
        {
            return Description;
        }
        public void AddWorkerMovie(WorkerMovie trabajador)//añade un trabajador de la pelicula a la lista de trabajadores
        {
            Cast.Add(trabajador);
        }

    }
}











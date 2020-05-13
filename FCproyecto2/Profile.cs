using System;
using System.Collections.Generic;
namespace FCproyecto2
{
    public class Profile
    {
        private string Email;
        private string Username;
        private string Password;
        private bool Privacy;
        private bool Premium;


        List<PlaylistM> PlaylistM = new List<PlaylistM> { }; //lista de playlist del usuario
        List<Movies> FavMovies = new List<Movies> { };//lista de peliculas favoritas del usuario
        List<PlaylistM> PlaylistFollowingM = new List<PlaylistM> { };//lista de playlist de peliculas q sigue el usuario
        List<WorkerMovie> WorkermovieFollowing= new List<WorkerMovie> { }; //lista de trabajadores de peliculas q sigue el usuario

        public Profile(string username,string email,string password, bool privacy, bool premium)
        {
            this.Username = username;
            this.Email = email;
            this.Password = password;
            this.Privacy = privacy;
            this.Premium = premium;
        }
        public void AddPlaylistM(PlaylistM playlistm) //para ir añadiendo tus playlist
        {
            PlaylistM.Add(playlistm);
        }

        public void AddFavMovie(Movies pelicula) //para ir añadiendo tus peliculas favoritas a la lista
        {
            FavMovies.Add(pelicula);
        }
        public void AddPlaylistFollowingM(PlaylistM seguidoplaylistm) //lista de playlists que sigue el usuario
        {
            PlaylistFollowingM.Add(seguidoplaylistm);
        }
        public void Addworkerfollowing(Workermovie trabajador)
        {
            WorkermovieFollowing.Add(trabajador)
        }


    }
}
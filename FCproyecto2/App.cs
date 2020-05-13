using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace FCproyecto2
{
    public class APP
    {
        protected List<Movies> DataBaseMovies = new List<Movies>();
        protected List<PlaylistM> DataBasePlaylistM = new List<PlaylistM> { };
        protected List<Movies> KeyWordMovies = new List<Movies> { };
        protected List<Songs> KeyWordSongs = new List<Songs> { };
        protected List<Songs> KeyWordSongs = new List<Songs> { };
        protected List<Songs> KeyWordRankingigualsongs = new List<Songs> { };//lista para en las cuales son igual la key y el ranking de songs
        protected List<Songs> KeyWordRankingmayorsongs = new List<Songs> { };
        protected List<Songs> KeyWordRankingmenorsongs = new List<Songs> { };
        protected List<Movies> KeyWordRankingigualmovies = new List<Movies> { };
        protected List<Movies> KeyWordRankingmenormovies = new List<Movies> { };
        protected List<Movies> KeyWordRankingmayormovies = new List<Movies> { };
        protected List<Movies> KeyWordCategoria = new List<Movies> { };

        public string SearchKeyWord(string Key, string type)
        {
            if (type == "Música")
            {
                foreach (Songs song in DataBaseSongs)
                {
                    if (Key == song.Name || Key == song.Album || Key == song.Songgenre || Key == song.Singer || Key == song.Composer || Key == song.Yearpublishs
                    || Key == song.TypefileS)
                    {
                        KeyWordSongs.Add(song); //Agrega las canciones que cumplan la coincidencia con el keyword
                    }
                }
                if (KeyWordSongs.Count == 0) //Si la lista no contiene canciones ningun tuvo coincidencia con el keyword
                {
                    return "No se encontraron coincidencias";
                }
                foreach (Songs song1 in KeyWordSongs)
                {
                    return song1.InfoSong(); //Retorna la info de las canciones de la lista (las que coinciden)
                }
                KeyWordSongs.Clear(); //Se resetea la lista para una nueva busqueda
            }
            if (type == "Películas") //Lo mismo pero con los métodos de las películas
            {
                foreach (Movies movie in DataBaseMovies)
                {
                    if (Key == movie.Title || Key == movie.Category || Key == movie.Description || Key == movie.Studio || Key == movie.YearPublishM || Key == movie.TypeFileM)
                    {
                        KeyWordMovies.Add(movie);
                    }
                }
                if (KeyWordMovies.Count == 0) //Si la lista no contiene canciones ningun tuvo coincidencia con el keyword
                {
                    return "No se encontraron coincidencias";
                }
                for (int i = 0; i < KeyWordMovies.Count; ++i)
                {
                    return KeyWordMovies[i].InfoMovie();
                }
                KeyWordMovies.Clear();
            }
        }
        public void AddMovies(Movies movie) //añadir a database playlist peliculas
        {
            DataBaseMovies.Add(movie);
        }
        public void EliminatePlaylistM(PlaylistM playlist) // para eliminar playlsit de peliculas
        {
            if (DataBasePlaylistM.Contains(playlist))
            {
                DataBasePlaylistM.Remove(playlist);
            }
            else
            {
                Console.WriteLine("No existe ninguna playlist con ese nombre para eliminar");
            }
        }
        public void SearchEvaligualsong(float Key)// guardar el lista las canciones que sean igual al valor del ranking key
        {
            foreach (Songs song in DataBaseSongs)
            {
                if (Key == song.rankings)
                {
                    KeyWordRankingigualsongs.Add(song);
                }
            }
            if (KeyWordRankingigualsongs.Count == 0)
            {
                Console.WriteLine("No hay ningun valor encontrado para su busqueda")
            }
        }
        public void SearchEvalmayorsong(float Key) //guardar en lista las canciones que mayor al vlaor del ranking key
        {
            foreach (Songs song in DataBaseSongs)
            {
                if (Key < song.rankings)
                {
                    KeyWordRankingmayorsongs.Add(song);
                }
            }
            if (KeyWordRankingmayorsongs.Count == 0)
            {
                Console.WriteLine("No hay ningun valor encontrado para su busqueda")
            }
        }
        public void SearchEvalmenorsong(float Key)//guardas en lista las cancoines que sean menor al valor del ranking key
        {
            foreach (Songs song in DataBaseSongs)
            {
                if (Key > song.rankings)
                {
                    KeyWordRankingmenorsongs.Add(song);
                }
            }
            if (KeyWordRankingmenorsongs.Count == 0)
            {
                Console.WriteLine("No hay ningun valor encontrado para su busqueda")
            }
        }

        public void SearchEvaligualmovies(float Key) //guardar en lista las peliculas que sean igual al valor del ranking key
        {
            foreach (Movies movie in DataBaseMovies)
            {
                if (Key == movie.RankingM)
                {
                    KeyWordRankingigualmovies.Add(movie);
                }
            }
            if (KeyWordRankingigualmovies.Count == 0)
            {
                Console.WriteLine("No hay ningun valor encontrado para su busqueda")
            }
        }
        public void SearchEvalmayormovies(float Key) //guardar en lista las peliculas que sean mayores al valor del ranking key
        {
            foreach (Movies movie in DataBaseMovies)
            {
                if (Key < movie.RankingM)
                {
                    KeyWordRankingmayormovies.Add(movie);
                }
            }
            if (KeyWordRankingmayormovies.Count == 0)
            {
                Console.WriteLine("No hay ningun valor encontrado para su busqueda")
            }
        }
        public void SearchEvalmenormovies(float Key)//guardar en lista las peliculas que sean menor al valor del ranking key
        {
            foreach (Movies movie in DataBaseMovies)
            {
                if (Key > movie.RankingM)
                {
                    KeyWordRankingmenormovies.Add(movie);
                }
            }
            if (KeyWordRankingmenormovies.Count == 0)
            {
                Console.WriteLine("No hay ningun valor encontrado para su busqueda")
            }
        }
        public void SearchCategoryMovies(string categoria) //para buscar por categoria, si estan las añade a la lista keywordcategoria
        {
            foreach (Movies movie in DataBaseMovies)
            {
                if (categoria == movie.Category)
                {
                    KeyWordCategoria.Add(movie);

                }
            }
            if (KeyWordCategoria.Count == 0)
            {
                Console.WriteLine("No existe esa categoria")
            }

        }
        public string SearchPlaylistM(string Name) //Arreglar Metodo
        {
            foreach (PlaylistM playlist in DataBasePlaylistM)
            {
                if (playlist.Name_PlaylistM == Name)
                {
                    if (playlist.PrivacyM == true) //Privada no se puede ver
                    {
                        return "Lo lamentamos, esta Playlist es privada";
                    }
                    if (playlist.PrivacyM == false) //Publica se puede ber
                    {
                        return playlist.PlaylistMinfo();
                    }
                }
                if (playlist.Name_PlaylistM != Name)
                {
                    return "no existe este nombre";
                }
            }
            return "";
        }
        public int PlaylistsInM()
        {
            foreach (PlaylistM playlist in DataBasePlaylistM)
            {
                Console.WriteLine(playlist.PlaylistMinfo());
            }
            return DataBasePlaylistM.Count;
        }


    }

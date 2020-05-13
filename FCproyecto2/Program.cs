using System;

namespace FCproyecto2
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //administrador

            string nombreplaylistcancion;
            bool privacidadcancion;
            string privacidadcancion1;
            string privacidadpelicula1
            string tipos;
            string tipom;
            string respuesta;
            string nombreplaylistbuscadas;
            string nombrecancionbuscada;
            string nombrepeliculabuscada;
            string nombreplaylistbuscadam;
            string keyword;
            string typekeyword;
            string nombreplaylistpelicula;
            bool privacidadpelicula;
            string nombreplaylistbuscadaelim;
            string respuestapoc;
            string valorverplaylist;
            APP app = new APP();
            Profile profile = new Profile("profile"...
            while (true)
            {
                //Menu de usuario (profile)
                Console.WriteLine("Menú: Elija una opcion numerica");
                Console.WriteLine(" ");
                Console.WriteLine("1) Crear Playlist");
                Console.WriteLine(" ");
                Console.WriteLine("2) Ver Playlist");
                Console.WriteLine(" ");
                Console.WriteLine("3) Añadir Canción a Playlist");
                Console.WriteLine(" ");
                Console.WriteLine("4) Buscar Canción");
                Console.WriteLine(" ");
                Console.WriteLine("5) Buscar Canción dentro de una Playlist");
                Console.WriteLine(" ");
                Console.WriteLine("6) Eliminar una cancion de la playlist");
                Console.WriteLine(" ");
                Console.WriteLine("7) Eliminar una playlist de canciones");
                Console.WriteLine(" ");
                Console.WriteLine("8) Añadir Pelicula a Playlist");
                Console.WriteLine(" ");
                Console.WriteLine("9) Buscar Pelicula");
                Console.WriteLine(" ");
                Console.WriteLine("10) Buscar Pelicula dentro de una Playlist");
                Console.WriteLine(" ");
                Console.WriteLine("11) Elminar una pelicula de la playlist");
                Console.WriteLine(" ");
                Console.WriteLine("12) Eliminar una Playlist de peliculas");
                Console.WriteLine(" ");
                Console.WriteLine("8) Búsqueda general"); //keyword
                Console.WriteLine(" ");
                Console.WriteLine("9) Salir de Spotify");
                Console.WriteLine(" ");
                Console.WriteLine(" ");

                respuesta = Console.ReadLine();
                if (respuesta == "1")
                {
                    Console.WriteLine("1) Canciones");
                    Console.WriteLine("");
                    Console.WriteLine("2) Peliculas");
                    respuestapoc = Console.ReadLine();
                    if (respuestapoc == "1")
                        Console.WriteLine("Nombre de la playlist");
                        nombreplaylistcancion = Console.ReadLine();
                        Console.WriteLine("Privacidad:");
                        privacidadcancion1 = Console.ReadLine();
                        if (privacidadcancion1 == "Privada")
                        {
                            privacidadcancion = true;
                        }
                        else //(privacidadcancion1=="Publica")
                        {
                            privacidadcancion = false;
                        }
                        Console.WriteLine("Tipo de Playlist");
                        tipos = Console.ReadLine();
                    //Console.ReadLine() le damos valores a los atributos
                        PlaylistS Playlist = new PlaylistS(profile.UserName1, nombreplaylistcancion, privacidadcancion, tipos);
                        Console.WriteLine("Playlist " + Playlist.Name_PlaylistS1 + " creada");
                        app.AddPlaylistStoDataBase(Playlist);
                    if (respuestapoc == "2")
                    {
                        Console.WriteLine("Nombre de la playlist");
                        nombreplaylistpelicula = Console.ReadLine();
                        Console.WriteLine("privacidad:");
                        privacidadpelicula1 = Console.ReadLine();
                        if (privacidadpelicula1 == "Privada")
                        {
                            privacidadpelicula = true;
                        }
                        else
                        {
                            privacidadpelicula = false;

                        }
                        Console.WriteLine("Tipo de playlist");
                        tipom = Console.ReadLine();
                        PlaylistM playlistpelicula = new PlaylistM(profile.usernamem1, nombreplaylistpelicula, privacidadpelicula, tipo);
                        Console.WriteLine("Playlist" + playlistpelicula.Name_PlaylistM + "creada");
                        app.AddMovies(playlistpelicula);
                    }   

                }
                if (respuesta == "2")
                {
                    Console.WriteLine("1) Peliculas");
                    Console.WriteLine("2) Canciones");
                    valorverplaylist = Console.ReadLine();
                    if (valorverplaylist == "1")
                    {
                        Console.WriteLine(app.PlaylistsInM);
                    }
                    else
                    {
                        Console.WriteLine(app.PlaylistsIn());
                    }

                }
                if (respuesta == "3") //Añadir cancion
                {
                    Console.WriteLine("Ingrese la playlist");
                    nombreplaylistbuscadas = Console.ReadLine();
                    //foreach()
                    //Buscar una cancion "cancion" en una playlist "playlist1"
                    //playlists1.SongSearchinPlaylist(cancion);
                }

                if (respuesta == "4")
                {
                    Console.WriteLine("Ingrese el nombre de la cancion:");
                    nombrecancionbuscada = Console.ReadLine();
                    //app.SearchSong(Song); ----> Arreglar, Metodo que busque el nombre de una cancion para agregarla

                }
                if (respuesta == "5") //Buscar una cancion "cancion" en una playlist "playlist1"
                {
                    //playlists1.SongSearchinPlaylist(cancion);

                }

                if (respuesta == "6")//Eliminar una cancion "song" de la "playlist1"
                {
                    //playlist1.EliminateSong(song)
                }
                if (respuesta == "7")
                {
                    Console.WriteLine("Ingrese el nombre de la playlist");
                    nombreplaylistbuscadas = Console.ReadLine();
                    //app.EliminatePlaylist(nombreplaylistbuscada-->playlist)
                }
                if( respuesta == "8")
                {
                    Console.WriteLine("Ingrese la playlist");
                    nombreplaylistbuscadam = Console.ReadLine();
                    //foreach()
                    //Buscar una pelicula "pelicula" en una playlist "playlist"
                    //playlists.AddmoviesP(pelicula)

                }
                if (respuesta== "9")
                {
                    Console.WriteLine("Ingrese nombre de la pelicula");
                    nombrepeliculabuscada = Console.ReadLine();
                    app.SearchPlaylistM(nombrepeliculabuscada);


                }
                if (respuesta == "10") //buscar una pelicula "pelicula" en una playlist2
                {
                    playlist2.MovieSearchingPlaylist(pelicula)


                }
                if (respuesta == "11") // Elminar pelicula(pelicula" de la "playlist2"
                {
                    playlist2.EliminateMovies();

                }
                if (respuesta == "12")
                {
                    Console.WriteLine("Ingrese el nombre de la playlist");
                    nombreplaylistbuscadaelim = Console.ReadLine();
                    app.EliminatePlaylistM(nombreplaylistbuscadaelim);



                }
                if (respuesta == "8")
                {
                    Console.WriteLine("Ingrese su búsqueda");
                    keyword = Console.ReadLine();
                    Console.WriteLine("Ingrese en que categoría desea buscar (Música/Películas):");
                    typekeyword = Console.ReadLine();
                    Console.WriteLine(app.SearchKeyWord(keyword, typekeyword));
                }
                if (respuesta == "9")
                {
                    Console.WriteLine("Saliendo del menú");
                    break;
                }






            }











            string titulo;
            string categoriam;
            string duracionm;
            float rankingm;
            string anopublicacionm;
            string calidadm;
            string tamanom;
            string descripccion;
            int likesm;
            int reproduccionesm;
            string tipoarchivom;
            string estudio;
            string tamanom;



        }
    }
}

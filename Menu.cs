using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpotiFlix
{
    internal class Menu
    {
        Data data = new Data();
        //Best practice -> save in LocalAppData folder instead of desktop
        string file = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"/Media.json";
        FileHandling fileHandling = new FileHandling();
        public Menu()
        {
            Init();
            Start();
        }

        private void Init()
        {
            //Check file exists. If not create new file, else load existing file
            if (File.Exists(file))
            {
                data = fileHandling.LoadData<Data>(file);
            }
            else
            {
                fileHandling.SaveData(file, data);
            }
        }

        void Start()
        {
            Console.Clear();
            Console.WriteLine("Welcome to your Media collection\n");
            Console.WriteLine("Press 1 for Music");
            Console.WriteLine("Press 2 for Movies");
            Console.WriteLine("Press 3 for Series");

            switch (Console.ReadKey(true).Key)
            {
                case ConsoleKey.D1:
                    MusicMenu();
                    break;
                case ConsoleKey.D2:
                    MoviesMenu();
                    break;
                case ConsoleKey.D3:
                    break;
                default:
                    break;
            }
        }
        private void MusicMenu()
        {
            Console.Clear();
            Console.WriteLine("Welcome to your Music collection\n");
            Console.WriteLine("Press 1 to show all");
            Console.WriteLine("Press 2 to search");
            Console.WriteLine("Press 3 to add new");

            switch (Console.ReadKey(true).Key)
            {
                case ConsoleKey.D1:
                case ConsoleKey.NumPad1:
                    ShowAllMusic();
                    break;
                case ConsoleKey.D2:
                case ConsoleKey.NumPad2:
                    SearchMusic();
                    break;
                case ConsoleKey.D3:
                case ConsoleKey.NumPad3:
                    AddNewMusic();
                    break;
                default:
                    break;
            }
        }


        private void ShowAllMusic()
        {
            foreach (var music in data.MusicList)
            {
                music.Show();
            }
        }
        private void SearchMusic()
        {

        }
        private void AddNewMusic()
        {
            Console.Clear();
            Console.WriteLine("Add song title");
            string title = Console.ReadLine();
            Console.WriteLine("\nAdd album");
            string album = Console.ReadLine();
            Console.WriteLine("\nAdd artist");
            string artist = Console.ReadLine();
            Console.WriteLine("\nAdd genre");
            MusicGenre musicGenre = PickAMusicGenre();
            Console.WriteLine("\nAdd length");
            string lengthInSeconds = Console.ReadLine();
            int length = int.Parse(lengthInSeconds);
            Console.WriteLine("\nAdd release date");
            string releaseDate = Console.ReadLine();
            DateTime release = DateTime.Parse(releaseDate);
            Console.WriteLine("\nAdd URL");
            string www = Console.ReadLine();

            Music music = new Music();
            music.Title = title;
            music.Album = album;
            music.Artist = artist;
            music.Genre = musicGenre;
            music.LengthInSeconds = length;
            music.ReleaseDate = release;
            music.Www = www;

            data.MusicList.Add(music);
            fileHandling.SaveData(file, data);
        }
        private MusicGenre PickAMusicGenre()
        {
            Console.WriteLine("\n*** Genres ****");
            int numberOfGenres = Enum.GetValues(typeof(MusicGenre)).Length;
            for (int i = 1; i <= numberOfGenres; i++)
            {
                Console.WriteLine(i + " " + (MusicGenre)i);
            }

            int mg = 0;
            Console.Write("\nPick a genre: ");
            while (!int.TryParse(Console.ReadLine(), out mg) || mg < 1 || mg > numberOfGenres)
            {
                Console.Write("Try again:");
            }
            return (MusicGenre)mg;
        }
        private void MoviesMenu()
        {
            Console.Clear();
            Console.WriteLine("Welcome to your Movie collection\n");
            Console.WriteLine("Press 1 to show all");
            Console.WriteLine("Press 2 to search");
            Console.WriteLine("Press 3 to add new");

            switch (Console.ReadKey(true).Key)
            {
                case ConsoleKey.D1:
                case ConsoleKey.NumPad1:
                    ShowAllMovies();
                    break;
                case ConsoleKey.D2:
                case ConsoleKey.NumPad2:
                    SearchMovies();
                    break;
                case ConsoleKey.D3:
                case ConsoleKey.NumPad3:
                    AddNewMovies();
                    break;
                default:
                    break;
            }
        }


        private void ShowAllMovies()
        {
            foreach (var movies in data.MovieList)
            {
                movies.Show();
            }
        }
        private void SearchMovies()
        {

        }
        private void AddNewMovies()
        {
            Console.Clear();
            Console.WriteLine("Add movie title");
            string title = Console.ReadLine();
            Console.WriteLine("\nAdd genre");
            Genre movieGenre = PickAMovieGenre();
            Console.WriteLine("\nAdd length (hh:mm)");
            string timeInput = Console.ReadLine();
            int lengthInSeconds = Tools.HourAndMinutesToSeconds(timeInput);
            Console.WriteLine("\nAdd release date");
            string releaseDate = Console.ReadLine();
            DateTime release = DateTime.Parse(releaseDate);
            Console.WriteLine("\nAdd URL");
            string www = Console.ReadLine();

            Movies movies = new Movies();
            movies.Title = title;
            movies.Genre = movieGenre;
            movies.LengthInSeconds = lengthInSeconds;
            movies.ReleaseDate = release;
            movies.Www = www;

            data.MovieList.Add(movies);
            fileHandling.SaveData(file, data);
        }
        private Genre PickAMovieGenre()
        {
            Console.WriteLine("\n*** Genres ****");
            int numberOfGenres = Enum.GetValues(typeof(Genre)).Length;
            for (int i = 1; i <= numberOfGenres; i++)
            {
                Console.WriteLine(i + " " + (Genre)i);
            }

            int mg = 0;
            Console.Write("\nPick a genre: ");
            while (!int.TryParse(Console.ReadLine(), out mg) || mg < 1 || mg > numberOfGenres)
            {
                Console.Write("Try again:");
            }
            return (Genre)mg;
        }
        private void SeriesMenu()
        {
            Console.Clear();
            Console.WriteLine("Welcome to your Series collection\n");
            Console.WriteLine("Press 1 to show all");
            Console.WriteLine("Press 2 to search");
            Console.WriteLine("Press 3 to add new");

            switch (Console.ReadKey(true).Key)
            {
                case ConsoleKey.D1:
                case ConsoleKey.NumPad1:
                    ShowAllSeries();
                    break;
                case ConsoleKey.D2:
                case ConsoleKey.NumPad2:
                    SearchSeries();
                    break;
                case ConsoleKey.D3:
                case ConsoleKey.NumPad3:
                    AddNewSeries();
                    break;
                default:
                    break;
            }
        }
        private void ShowAllSeries()
        {
            foreach (var movies in data.SeriesList)
            {
                series.Show();
            }
        }
    }
    private void SearchSeries()
    {

    }
    private void AddNewSeries()
    {
        Console.Clear();
        Console.WriteLine("Add series title");
        string title = Console.ReadLine();
        Console.WriteLine("\nAdd genre");
        Genre seriesGenre = PickASeriesGenre();
        Console.WriteLine("\nAdd length (hh:mm)");
        string timeInput = Console.ReadLine();
        int lengthInSeconds = Tools.HourAndMinutesToSeconds(timeInput);
        Console.WriteLine("\nAdd release date");
        string releaseDate = Console.ReadLine();
        DateTime release = DateTime.Parse(releaseDate);
        Console.WriteLine("\nAdd URL");
        string www = Console.ReadLine();

        Series series = new Series();
        series.Title = title;
        series.Genre = seriesGenre;
        series.LengthInSeconds = lengthInSeconds;
        series.ReleaseDate = release;
        series.Www = www;

        data.SeriesList.Add(series);
        fileHandling.SaveData(file, data);
    }
    private Genre PickASeriesGenre()
    {
        Console.WriteLine("\n*** Genres ****");
        int numberOfGenres = Enum.GetValues(typeof(Genre)).Length;
        for (int i = 1; i <= numberOfGenres; i++)
        {
            Console.WriteLine(i + " " + (Genre)i);
        }

        int mg = 0;
        Console.Write("\nPick a genre: ");
        while (!int.TryParse(Console.ReadLine(), out mg) || mg < 1 || mg > numberOfGenres)
        {
            Console.Write("Try again:");
        }
        return (Genre)mg;
    }
}
}

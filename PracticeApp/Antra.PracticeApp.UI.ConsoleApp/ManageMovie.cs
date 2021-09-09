using Antra.CompanyApp.Data.Model;
using Antra.CompanyApp.Data.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace Antra.PracticeApp.UI.ConsoleApp
{
    class ManageMovie
    {
        IRepository<Movie> movieRepository;
        public ManageMovie()
        {
            movieRepository = new MovieRepository();
        }

        void AddMovie()
        {
            Movie m = new Movie();
            Console.Write("Enter Movie Name => ");
            m.MovieName = Console.ReadLine();
            Console.Write("Enter Movie Genre => ");
            m.MovieGenre = Console.ReadLine();

            if (movieRepository.Insert(m) > 0)
                Console.WriteLine("Movie Added Successfully");
            else
                Console.WriteLine("Some error has occured");
        }
        void DeleteMovie()
        {
            Console.Write("Enter Id => ");
            int id = Convert.ToInt32(Console.ReadLine());
            if (movieRepository.Delete(id) > 0)
                Console.WriteLine("Movie Deleted Successfully");
            else
                Console.WriteLine("Some error has occured");
        }

        void UpdateMovie()
        {
            Movie m = new Movie();
            Console.Write("Enter Movie Id => ");
            m.Id = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Movie Name => ");
            m.MovieName = Console.ReadLine();
            Console.Write("Enter Movie Genre => ");
            m.MovieGenre = Console.ReadLine();

            if (movieRepository.Update(m) > 0)
                Console.WriteLine("Movie Updated Successfully");
            else
                Console.WriteLine("Some error has occured");
        }

        public void Run()
        {
            UpdateMovie();
        }
    }
}

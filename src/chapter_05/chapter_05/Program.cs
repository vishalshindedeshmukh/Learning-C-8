﻿using chapter_05.Interfaces;
using System;

namespace chapter_05
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();
            employee.Name = "John";
            employee.Salary = 20000;

            Console.WriteLine("Name of Employee is {0}", employee.Name);
            Console.WriteLine("Salary of Employee is {0}", employee.Salary);

            EmployeeOverload employeeOverload = new EmployeeOverload();
            employeeOverload.FullName("William");
            employeeOverload.FullName("John", "Doe");
            string FullName = employeeOverload.FullName("Harry", "James", "Potter");
            Console.WriteLine("The full Name of Employee is {0}", FullName);

            ComplexNumber complexNumber1 = new ComplexNumber(2, 3);
            ComplexNumber complexNumber2 = new ComplexNumber(4, 5);

            ComplexNumber complexNumber3 = complexNumber1 + complexNumber2;
            ComplexNumber complexNumber4 = new ComplexNumber(5, 7);
            complexNumber4++;

            Console.WriteLine("The sum of given complex numbers is " + complexNumber3.Real + "+i" + complexNumber3.Imaginary);
            Console.WriteLine("The complex number after applying increment will be " + complexNumber4.Real + "+i" + complexNumber4.Imaginary);

            Car car = new Car("Jaguar", 4, "Automatic");
            car.ShowDetails();
            car.GetTransmission();

            Bicycle bicycle = new Bicycle("Atlas", 2);
            bicycle.ShowDetails();

            Rectangle rectangle = new Rectangle(5, 3);
            Console.WriteLine("The perimeter of Rectangle is {0}", rectangle.CalculatePerimeter());

            Circle circle = new Circle(7);
            Console.WriteLine("The perimeter of Rectangle is {0}", circle.CalculatePerimeter());

            CreditCard creditCard = new CreditCard(10000);
            Console.WriteLine("The expense limit for Normal credit card is {0}", creditCard.CardLimit());

            GoldCard goldCreditCard = new GoldCard(10000);
            Console.WriteLine("The expense limit for Gold credit card is {0}", goldCreditCard.CardLimit());

            PlatinumCard platinumCreditCard = new PlatinumCard(10000);
            Console.WriteLine("The expense limit for Platinum credit card is {0}", platinumCreditCard.CardLimit());

            Movie movie = new Movie("Avengers", 10);
            MovieRentalService movieRentalService = new MovieRentalService(movie.MovieName, movie.DaysRented);
            movieRentalService.GetMovieDetails();
            Console.WriteLine("The rent for movie is {0}", movieRentalService.CalculateRent());

            Book book = new Book("Harry Potter", 15);
            BookRentalService bookRentalService = new BookRentalService(book.BookName, book.DaysRented);
            bookRentalService.GetBookDetails();
            Console.WriteLine("The rent for book is {0}", bookRentalService.CalculateRent());

            RentalService rentalService = new RentalService(book, movie);

            rentalService.GetMovieDetails();
            Console.WriteLine("The rent for movie is {0}", ((IMovie)rentalService).CalculateRent());
            rentalService.GetBookDetails();
            Console.WriteLine("The rent for book is {0}", ((IBook)rentalService).CalculateRent());

            Console.ReadLine();
        }
    }
}
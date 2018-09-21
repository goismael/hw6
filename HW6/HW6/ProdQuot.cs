using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW6
{
    class ProdQuot
    {
        static void Main(string[] args)
        {

            try

            {
                Random rnd = new Random();

                decimal X, Y, prod, quot = 0;

                for (decimal counter = 1; counter <= 11; counter++)

                {
                    X = rnd.Next(0, 11);

                    Y = rnd.Next(0, 11);

                    prod = X * Y;
                    quot = X / Y;
                    
                    Console.WriteLine("The product of " + X + "," + Y + " = " + prod);
                    Console.WriteLine("The quotient of " + X + "," + Y + " = " +  Math.Round(quot, 2));
                    Console.WriteLine( );

                }
            }
            catch (DivideByZeroException)
            { 
                Console.WriteLine("Divide By Zero Exception caught!");
            }
            catch (Exception ex)
            
            {
                Console.WriteLine("General Exception Thrown " + ex.Message);
            }

            finally
            {


                Console.ReadLine();

            }

            }
        }
    }


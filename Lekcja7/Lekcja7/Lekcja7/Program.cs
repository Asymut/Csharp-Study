namespace Lekcja7
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // TRY, CATCH

            int[] nums = new int[1];
            
            try
            {
                int y = int.Parse("ABC");  // wyjatek

                int x = 2 / int.Parse("0");

                nums[1] = 2;
                Console.WriteLine("przerywa");
            }
            catch(IndexOutOfRangeException ex) 
            {
                Console.WriteLine(ex.Message);
            }
            catch (DivideByZeroException ex) 
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex) 
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine( "Wykona się i tak.");
            
            }


            Console.WriteLine("Nie przerywa");


            Console.WriteLine(); Console.WriteLine();
            // WŁASNE WYJĄTKI

            try 
            { 
            Console.WriteLine(Silnia(-5));
            }
            catch(Exception ex) 
            {
                Console.WriteLine(ex.Message); 
            }
        }


        static int Silnia(int n) 
        {
            if (n < 0) 
            {
                throw new SilniaException();
            }
            else if(n == 0) 
            { 
                return 1; 
            }
            else 
            { 
                return n * Silnia(n-1);
            }
            
        
        }
    }

    class SilniaException : Exception 
    {
        public override string Message 
        {
            get { return " Wyjątek klasy SILNIA. "; }
        }

    }

}
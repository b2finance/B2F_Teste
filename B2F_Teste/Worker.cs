namespace B2F_Teste
{
    public class Worker : BackgroundService
    {
        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while (true)
            {
                Console.WriteLine("1");
                Console.WriteLine("2");
                Console.WriteLine("3");

                Console.WriteLine("Serviço iniciado");
                Console.WriteLine("Serviço finalizado");
                Console.ReadLine();
            }
        }

    }
}

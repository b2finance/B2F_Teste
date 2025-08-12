using Squirrel;

namespace B2F_Teste
{
    public class Worker : BackgroundService
    {
        private readonly ILogger<Worker> _logger;

        public Worker(ILogger<Worker> logger)
        {
            _logger = logger;
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while (true)
            {
                var manager = await UpdateManager.GitHubUpdateManager("https://github.com/b2finance/B2F_Teste");
                Console.WriteLine("Versão atual: " + manager.CurrentlyInstalledVersion().ToString());

                var updateInfo = await manager.CheckForUpdate();

                if (updateInfo.ReleasesToApply.Count > 0)
                {
                    Console.WriteLine("Atualização disponível: " + updateInfo.FutureReleaseEntry.Version.ToString());
                    await manager.UpdateApp();
                    Console.WriteLine("Aplicativo atualizado para a versão: " + updateInfo.FutureReleaseEntry.Version.ToString());
                }
                else
                {
                    Console.WriteLine("Nenhuma atualização disponível.");
                }
            }
        }
    }
}

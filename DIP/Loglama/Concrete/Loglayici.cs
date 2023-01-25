using DIP.Loglama.Abstract;

namespace DIP.Loglama.Concrete
{
    public class Loglayici
    {
        private ILogger _logger;
        public void Logla(ILogger logger, string message)
        {
            _logger = logger;

            _logger.Logla(message);

        }
    }
}

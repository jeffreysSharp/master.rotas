using Master.Rotas.Business.Intefaces;
using Master.Rotas.Business.Interfaces;

namespace Master.Rotas.Tests.Business
{
    public class RotaServiceTestes
    {
        private readonly IRotaRepository _rotaRepository ;
        private readonly INotificador _notificador ;

        public RotaServiceTestes(IRotaRepository rotaRepository, 
                                 INotificador notificador)
        {
            _rotaRepository = rotaRepository;
            _notificador = notificador;
        }

        [Fact]
        public void Rota_Adicionar_RetortarRota()
        {
            // Arrange 

            // Act

            // Assert
        }
    }
}

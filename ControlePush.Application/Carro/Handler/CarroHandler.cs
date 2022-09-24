using ControlePush.Application.Carro.Handler.Command;
using ControlePush.Application.Carro.Handler.Query;
using ControlePush.Application.Carro.Service;
using MediatR;

namespace ControlePush.Application.Carro.Handler
{
    public class CarroHandler : IRequestHandler<CreateCarroCommand, CreateCarroCommandResponse>,
                                //IRequestHandler<UpdateCarroCommand, UpdateCarroCommandResponse>,
                                IRequestHandler<GetAllCarrosQuery, GetAllCarrosQueryResponse>
    {
        private readonly ICarroService _carroService;

        public CarroHandler(ICarroService carroService)
        {
            _carroService = carroService;
        }

        public async Task<CreateCarroCommandResponse> Handle(CreateCarroCommand request, CancellationToken cancellationToken)
        {
            var result = await this._carroService.Criar(request.Carro);
            return new CreateCarroCommandResponse(result);
        }

        public async Task<GetAllCarrosQueryResponse> Handle(GetAllCarrosQuery request, CancellationToken cancellationToken)
        {
            var result = await this._carroService.ObterTodos();
            return new GetAllCarrosQueryResponse(result);
        }

        public async Task<GetCarroQueryResponse> Handle(GetCarroQuery request, CancellationToken cancellationToken)
        {
            var result = await this._carroService.ObterCarro(request.IdCarro);
            return new GetCarroQueryResponse(result);
        }

        //public async Task<UpdateCarroCommandResponse> Handle(UpdateCarroCommand request, CancellationToken cancellationToken)
        //{
        //    this._carroService.Editar(request.Carro);
        //    var response = new UpdateCarroCommandResponse();
        //    return new 
        //}
    }
}

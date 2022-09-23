using ControlePush.Application.Carro.Service;
using ControlePush.Application.Mensagem.Service;
using ControlePush.Application.Usuario.Service;
using MediatR;
using Microsoft.Extensions.DependencyInjection;

namespace ControlePush.Application
{
    public static class ConfigurationModule
    {
        public static IServiceCollection RegisterApplication(this IServiceCollection services)
        {
            services.AddAutoMapper(typeof(Application.ConfigurationModule).Assembly);

            services.AddMediatR(typeof(ConfigurationModule).Assembly);

            services.AddScoped<ICarroService, CarroService>();
            services.AddScoped<IMensagemService, MensagemService>();
            services.AddScoped<IUsuarioService, UsuarioService>();

            return services;
        }
    }
}

using Dev.Business.Interfaces;
using Dev.Business.Models;
using Dev.Business.Notificacoes;
using FluentValidation;
using FluentValidation.Results;

namespace Dev.Business.Services
{
    public abstract class BaseService
    {
        private readonly INotificador _notificador;

        protected BaseService(INotificador notificador)
        {
            _notificador = notificador;
        }

        protected void Notificar(ValidationResult validationResult)
        {
            foreach (var error in validationResult.Errors)
            {
                Notificar(error.ErrorMessage);
            }
        }

        protected void Notificar(string mensagem)
        {
            // Propagar esse erro até a camada de apresentaçao
            _notificador.Handle(new Notificacao(mensagem));
        }

        /// <summary>
        /// Executar validação
        /// </summary>
        /// <typeparam name="TV">Entidade Generica Validation</typeparam>
        /// <typeparam name="TE">Entidade Generica Entidade (Model)</typeparam>
        /// <param name="validacao">Validação</param>
        /// <param name="entidade">Entidade</param>
        /// <returns></returns>
        protected bool ExecutarValidacao<TV, TE>(TV validacao, TE entidade) where TV : AbstractValidator<TE> where TE : Entity
        {
            var validator = validacao.Validate(entidade);

            if (validator.IsValid) return true;

            Notificar(validator);

            return false;
        }
    }
}

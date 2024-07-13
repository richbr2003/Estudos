using Dominio;
using Dominio.Contrato;
using Estudos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RepositorioEF
{
    public class UserRepositorioEF : IRepositorioPessoa<Pessoa>
    {
        private readonly Contexto contexto;

        public UserRepositorioEF()
        {
            contexto = new Contexto();
        }

        public void Excluir(Pessoa entidade)
        {
            throw new NotImplementedException();
        }

        public Pessoa ListarPorId(string ClienteId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Pessoa> ListarTodos()
        {
            throw new NotImplementedException();
        }

        public void Salvar(Pessoa entidade)
        {
            if (entidade.id > 0)
            {
                var Alterar = contexto.pessoa.First(x => x.id == entidade.id);
               
                Alterar.Nome = entidade.Nome;
                Alterar.Cpf = entidade.Cpf;
                Alterar.Sexo = entidade.Sexo;
                Alterar.Cnh = entidade.Cnh;

            }
            else
            {
                contexto.pessoa.Add(entidade);
            }
            contexto.SaveChanges();
        }
    }
}
using Dominio;
using Dominio.Contrato;
using Estudos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Aplicacao
{
    public class UserAplicacao
    {
        private readonly IRepositorioPessoa<Pessoa> repositorio;


        public UserAplicacao(IRepositorioPessoa<Pessoa> repo)
        {
            repositorio = repo;
        }



        public void Salvar(Pessoa ali)
        {
            repositorio.Salvar(ali);

        }
    }
}
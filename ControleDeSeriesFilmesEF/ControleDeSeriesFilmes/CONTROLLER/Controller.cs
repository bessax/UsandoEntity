using ControleDeSeriesFilmes.MODEL;
using System;
using System.Collections.Generic;
using System.Linq;


namespace ControleDeSeriesFilmes.CONTROLLER
{
    static class Controller
    {
        static EFFilmesSeries daofilmes = new EFFilmesSeries();

        static public List<filme> GetFilmes() {
            return daofilmes.filmes.ToList();            
        }

    
        static public int InsertFilme(filme _filme)
        {
            int retorno = 0;
            try
            {
                //Adiciona o filme na base de dados
                daofilmes.filmes.Add(_filme);
               // salva as alterações
                daofilmes.SaveChanges();
                retorno = 1;
            }
            catch (Exception)
            {

                throw;
            }

            return retorno;
        }

        static public int InsertFilme(string nome,string diretor,int duracao,string classificacao,string estudio)
        {
            int retorno = 0;
            try
            {
                 filme _filme = new filme();
                _filme.Diretor = diretor;
                _filme.Duracao = duracao;
                _filme.Classificacao = classificacao;
                _filme.Nome = nome;
                _filme.Estudio = estudio;
                daofilmes.filmes.Add(_filme);
                daofilmes.SaveChanges();
                retorno = 1;
            }
            catch (Exception)
            {

                throw;
            }

            return retorno;
        }

        static public int UpdateFilme(filme _filme)
        {
            int retorno = 0;
            try
            {
                // procuro o objeto no "Contexto" da aplicação;
                var _filmeTeMp = daofilmes.filmes.Find(_filme.Id);
                // Alterando os campos 
                _filmeTeMp.Diretor = _filme.Diretor;
                _filmeTeMp.Duracao = _filme.Duracao;
                _filmeTeMp.Classificacao = _filme.Classificacao;
                _filmeTeMp.Nome = _filme.Nome;
                _filmeTeMp.Estudio = _filme.Estudio;
                _filmeTeMp.Id = _filme.Id;     
                // Salvando as alterações no banco de dados         
                daofilmes.SaveChanges();
                retorno = 1;
            }
            catch (Exception)
            {

                throw;
            }

            return retorno;
        }



        static public int DeleteFilme(filme _filme)
        {
            int retorno = 0;
            try
            {
                // Pesquiso o filme a ser deletado pelo ID.
                var _filmeTeMp = daofilmes.filmes.Find(_filme.Id);
                //Removo o filme encontrado da base de dados.
                daofilmes.filmes.Remove(_filmeTeMp);
                // salvo as alterações.
                daofilmes.SaveChanges();
                retorno = 1;
            }
            catch (Exception)
            {

                throw;
            }

            return retorno;
        }



    }
}

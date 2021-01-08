using System;
using System.Collections.Generic;
using DIO.Serie.Interfaces;



namespace DIO.Serie
{
    public class SerieRepositorio : IRepositorio<Serie>
    {
        private List<serie> listaSerie = new List<serie>();

        public void Atualiza(int id, Serie entidade)
        {
            throw new NotImplementedException();
        }
        public void Exclui(int id)
        {
            throw new NotImplementedException();
        }
        public void Insere(Serie entidade)
        {
            throw new NotImplementedException();
        }
        public List<Serie> Lista()
        {
            throw new NotImplementedException();
        }
        public int ProximoId()
        {
            throw new NotImplementedException();
        }
    }
}

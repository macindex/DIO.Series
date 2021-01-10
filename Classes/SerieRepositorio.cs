using System;
using System.Collections.Generic;
using DIO.Serie.Interfaces;



namespace DIO.Serie
{
    public class SerieRepositorio : IRepositorio<Serie>
    {
        private List<serie> listaSerie = new List<serie>();

        public void Atualiza(int id, Serie objeto)
        {
            listaSerie[id] = entidade;
        }
        public void Exclui(int id)
        {
            listaSerie[id].Excluir();
        }
        public void Insere(Serie entidade)
        {
            listaSerie.Add(objeto);
        }
        public List<Serie> Lista()
        {
            return listaSerie;
        }
        public int ProximoId()
        {
           return listaSerie.Count;
        }
        public Serie RetornaPorId()
        {
            return listaSerie[id];
        }
    }
}

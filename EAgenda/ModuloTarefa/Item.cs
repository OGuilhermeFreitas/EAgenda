using EAgenda.Compartilhado;
using System;

namespace EAgenda.ModuloTarefa
{
    public class Item : EntidadeBase
    {
        private string descricao;
        private bool status = false;

        public Item(string descricao)
        {
            this.descricao = descricao;
        }

        public void AlterarStatus()
        {
            if (status == false)
                status = true;
            else
                status = false;
        }

        public bool Status { get => status; }

        public override string ToString()
        {
            string status = Status ? "Finalizado!" : "Em progresso...";

            return "Descrição: " + descricao + Environment.NewLine +
                "Status: " + status + Environment.NewLine;
        }

    }
}

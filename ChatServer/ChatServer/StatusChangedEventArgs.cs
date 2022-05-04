using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatServer
{
    // Trata os argumentos para o evento StatusChanged
    public class StatusChangedEventArgs : EventArgs
    {
        // Estamos interessados na mensagem descrevendo o evento
        private string EventMsg;

        // Propriedade para retornar e definir um mensagem do evento
        public string EventMessage
        {
            get { return EventMsg; }
            set { EventMsg = value; }
        }

        // Construtor para definir a mensagem do evento
        public StatusChangedEventArgs(string strEventMsg)
        {
            EventMsg = strEventMsg;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransportApp
{
    class Forms 
    {
        static public void OpenSearchConnectionsForm()
        {
            SearchConnectionsForm FormSearchConnection = new SearchConnectionsForm();
            CloseForm();
            FormSearchConnection.Show();
        }

        static public void OpenSearchDeparturesForm()
        {
            SearchDeparturesForm FormSearchDepartures = new SearchDeparturesForm();
            FormSearchDepartures.Show();
        }

        public static void CloseForm()
        {
            
        }

    }
}

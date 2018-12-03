using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;

namespace TransportApp
{
    class Forms//Klasse für das öffnen der einzelnen Forms
    {
        static private SearchConnectionsForm OriginalFormVar;

        static public void OpenSearchConnectionsForm()
        {
            SearchConnectionsForm FormSearchConnection = new SearchConnectionsForm();
            FormSearchConnection.Show();
        }

        static public void OpenSearchDeparturesForm(SearchConnectionsForm OrginalForm)
        {
            SearchDeparturesForm FormSearchDepartures = new SearchDeparturesForm();
            OriginalFormVar = OrginalForm;
            FormSearchDepartures.Closed += new System.EventHandler(CloseForm);
            FormSearchDepartures.Show();
        }

        public static void CloseForm(object sender, EventArgs e)
        {
            OriginalFormVar.Show();
        }

    }
}

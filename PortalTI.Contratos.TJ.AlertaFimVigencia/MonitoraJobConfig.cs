using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.SharePoint.Administration;

namespace PortalTI.Contratos.TJ.AlertaFimVigencia
{
    public class MonitoraJobConfig: SPPersistedObject
    {
        public static string ConfigNome = "MonitoraJobConfig";
        public MonitoraJobConfig() { }
        public MonitoraJobConfig(SPPersistedObject parent, Guid id) : base(ConfigNome, parent, id) { }

        [Persisted]
        public string EmailDestino;
    }
}

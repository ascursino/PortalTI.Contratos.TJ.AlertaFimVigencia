namespace PortalTI.Contratos.TJ.AlertaFimVigencia
{
    class mdConfig
    {
        //Comum
        public string user = "portalpmo";
        public string password = "b2w@123456";
        public string uri = "/_vti_bin/listdata.svc";
        public string linkContratoView = "/Lists/Contratos/DispForm.aspx";

        //Produção
        public string siteContratos = "http://portalti.b2w/contratos";
        public string domain = "lab2w";
        public string mailhost = "bwuolhub01.la.ad.b2w";
        public string mailfrom = "noreply@b2wdigital.com";

        //Desenv
        //public string siteContratos = "http://bwspdev01:4050/contratos";
        //public string domain = "la.ad.b2w";
        //public string mailhost = "BWSPDEV01.la.ad.b2w";
        //public string mailfrom = "sharepoint@BWSPDEV01.la.ad.b2w.com";
    }
}

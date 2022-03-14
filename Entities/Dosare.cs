namespace PassOrganiser.Entities
{
    public class Dosare
    {
       
        public string id_dosar { get; set; }
        public string id_creditor { get; set; }
        public string id_debitor { get; set; }
        public string nr_dosar { get; set; }
        public string creditor { get; set; }
        public string adresa_creditor { get; set; }
        public string debitor { get; set; }
        public string cnp_debitor { get; set; }
        public string adresa_debitor { get; set; }
        public string titlu_executoriu { get; set; }


        public Dosare( string idDosar, string idCreditor, string idDebitor, string nrDosar, string creditor, string adresaCreditor, string debitor, string cnpDebitor, string adresaDebitor, string titluExecutoriu )
        {
            id_dosar = idDosar;
            id_creditor = idCreditor;
            id_debitor = idDebitor;
            nr_dosar = nrDosar;
            this.creditor = creditor;
            adresa_creditor = adresaCreditor;
            this.debitor = debitor;
            cnp_debitor = cnpDebitor;
            adresa_debitor = adresaDebitor;
            titlu_executoriu = titluExecutoriu;
        }

        public override string ToString()
        {
            return String.Format(@"DOSAR: {3}

        id dosar: {0}
        id_creditor: {1}
        id_debitor: {2}
        creditor: {4}
        adresa_creditor: {5}
        debitor: {6}
        cnp_debitor: {7}
        adresa_debitor: {8}
        titlu_executoriu: {9}",  id_dosar, id_creditor, id_debitor, nr_dosar, creditor, adresa_creditor, 
                             debitor, cnp_debitor, adresa_debitor, titlu_executoriu
                );
        }
    }

}
